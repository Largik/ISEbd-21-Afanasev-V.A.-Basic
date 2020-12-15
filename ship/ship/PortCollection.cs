using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ship
{
    /// <summary>
    /// Класс-коллекция парковок
    /// </summary>
    class PortCollection
    {
        /// <summary>
        /// Словарь (хранилище) с парковками
        /// </summary>
        readonly Dictionary<string, Port<Ship>> portStages;
        /// <summary>
        /// Возвращение списка названий праковок
        /// </summary>
        public List<string> Keys => portStages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Разделитель для записи информации в файл
        /// </summary>
        private readonly char separator = ':';
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public PortCollection(int pictureWidth, int pictureHeight)
        {
            portStages = new Dictionary<string, Port<Ship>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        /// <summary>
        /// Добавление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void AddPort(string name)
        {
            if (portStages.ContainsKey(name))
            {
                return;
            }
            portStages.Add(name, new Port<Ship>(pictureWidth, pictureHeight));
        }
        /// <summary>
        /// Удаление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void DelPort(string name)
        {
            if (portStages.ContainsKey(name))
            {
                portStages.Remove(name);
            }
        }
        /// <summary>
        /// Доступ к парковке
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Port<Ship> this[string ind]
        {
            get
            {
                if (portStages.ContainsKey(ind))
                {
                    return portStages[ind];
                }
                return null;
            }
        }
        /// <summary>
        /// Метод записи информации в файл
        /// </summary>
        /// <param name="text">Строка, которую следует записать</param>
        /// <param name="stream">Поток для записи</param>
        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
        /// <summary>
        /// Сохранение информации по автомобилям на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                WriteToFile($"PortCollection{Environment.NewLine}", fs);
                foreach (var level in portStages)
                {
                    //Начинаем парковку
                    WriteToFile($"Port{separator}{level.Key}{Environment.NewLine}",
                    fs);
                    foreach (ITransport ship in level.Value)
                    {
                        //Записываем тип мшаины
                        if (ship.GetType().Name == "DefaultShip")
                        {
                            WriteToFile($"DefaultShip{separator}", fs);
                        }
                        if (ship.GetType().Name == "MotorShip")
                        {
                            WriteToFile($"MotorShip{separator}", fs);
                        }
                        //Записываемые параметры
                        WriteToFile(ship + Environment.NewLine, fs);
                    }
                }
            }
        }
        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                byte[] b = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    bufferTextFromFile += temp.GetString(b);
                }
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("PortCollection"))
            {
                portStages.Clear();
            }
            else
            {
                throw new FileLoadException("Неверный формат файла");
            }
            Ship ship = null;
            string key = string.Empty;
            for (int i = 1; i < strs.Length; ++i)
            {
                if (strs[i].Contains("Port"))
                {
                    key = strs[i].Split(separator)[1];
                    portStages.Add(key, new Port<Ship>(pictureWidth, pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }
                if (strs[i].Split(separator)[0] == "DefaultShip")
                {
                    ship = new DefaultShip(strs[i].Split(separator)[1]);
                }
                else if (strs[i].Split(separator)[0] == "MotorShip")
                {
                    ship = new MotorShip(strs[i].Split(separator)[1]);
                }
                if (!(portStages[key] + ship))
                {
                    throw new PortOverflowException();
                }
            }
        }
    }
}