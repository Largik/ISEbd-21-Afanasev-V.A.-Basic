using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ship
{
    /// <summary>
    /// Параметризованный класс для хранения набора объектов от интерфейса ITransport
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Port<T> where T : class, ITransport
    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private readonly T[] _places;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int _pictureHeight;
        /// <summary>
        /// Размер парковочного места (ширина)
        /// </summary>
        private readonly int _placeSizeWidth = 210;
        /// <summary>
        /// Размер парковочного места (высота)
        /// </summary>
        private readonly int _placeSizeHeight = 120;
        /// <summary>
        /// Свободные места
        /// </summary>
        private readonly int _column;
        /// <summary>
        /// Свободные места
        /// </summary>
        public int _placeFree
        {
            get { return FreePlaces(_places); }
        }
        /// <summary>
        /// Следующий корабль
        /// </summary>
        public int NextShip { get; private set; } = 0;
        /// <summary>
        /// Координата X для следующего
        /// </summary>
        public int XShip { get; private set; } = 5;
        /// <summary>
        /// Координата Y для следующего
        /// </summary>
        public int YShip { get; private set; } = 50;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth">Размер порта - ширина</param>
        /// <param name="picHeight">Размер порта - высота</param>
        public Port(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _column = height;
            _places = new T[width * height];
            _pictureWidth = picWidth;
            _pictureHeight = picHeight;
        }
        /// <summary>
        /// Проверка на свободное место
        /// </summary>
        /// /// <param name="place">Место</param>
        private static bool isFullParking(T[] place)
        {
            foreach (var item in place)
            {
                if (item == null)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Количество свободных мест
        /// </summary>
        /// /// <param name="place">Место</param>
        private static int FreePlaces(T[] array)
        {
            int freePlaces = 0;

            foreach (var item in array)
            {
                if (item == null)
                {
                    freePlaces++;
                }
            }
            return freePlaces;
        }
        /// <summary>
        /// Размещение корабля в порту
        /// </summary>
        /// /// <param name="ship">корабль</param>
        private void PlaceShip(T ship)
        {
            _places[NextShip] = ship;

            if (NextShip < _places.Length - 1 && !isFullParking(_places))
            {
                while (_places[NextShip] != null)
                {
                    NextShip++;
                }
            }
            XShip = NextShip / _column * _placeSizeWidth + 5;
            YShip = 50 + NextShip % _column * _placeSizeHeight;
        }
        /// <summary>
        /// Забираем корабль с порта
        /// </summary>
        /// /// <param name="index"> индекс корабля</param>
        public void takeShip(int index)
        {
            _places[index] = null;
            NextShip = 0;
            while (NextShip < _places.Length - 1 && _places[NextShip] != null)
            {
                NextShip++;
            }
            XShip = NextShip / _column * _placeSizeWidth + 5;
            YShip = 105 + NextShip % _column * _placeSizeHeight;
        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: на парковку добавляется корабль
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="ship">Добавляемый корабль</param>
        /// <returns></returns>
        public static T operator +(Port<T> Port, T ship)
        {
            Port.PlaceShip(ship);
            return ship;
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с парковки забираем корабль
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь объект</param>
        /// <returns></returns>
        public static T operator -(Port<T> Port, int index)
        {
            return Port._places[index];
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }
        /// <summary>
        /// Метод отрисовки разметки парковочных мест
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < _pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < _pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия разметки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (_pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}
