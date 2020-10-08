﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ship
{
    public class DefaultShip : Ship
    {
        /// <summary>
        /// Ширина отрисовки корабля
        /// </summary>
        protected readonly int shipWidth = 120;
        /// <summary>
        /// Высота отрисовки корабля
        /// </summary>
        protected readonly int shipHeight = 58;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _maxHeight;
        private readonly Color DopColor;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес корабля</param>
        /// <param name="mainColor">Основной цвет</param>
        public DefaultShip(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = Color.Green;

        }
        /// <summary>
        /// Конструкторс изменением размеров машины
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес корабля</param>
        /// <param name="mainColor">Основной цвет</param>
        /// <param name="shipWidth">Ширина отрисовки корабля</param>
        /// <param name="shipHeight">Высота отрисовки корабля</param>
        protected DefaultShip(int maxSpeed, float weight, Color mainColor,Color dopColor, int shipWidth, int
       shipHeight)
        {
            _maxHeight = 45;
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            this.shipWidth = shipWidth;
            this.shipHeight = shipHeight;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - shipWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:

                    if (_startPosY - step > _maxHeight)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - shipHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(MainColor);
            SolidBrush brWh = new SolidBrush(Color.White);
            //Палуба
            Point plate1 = new Point((int)_startPosX, (int)_startPosY);
            Point plate2 = new Point((int)_startPosX + 12, (int)_startPosY + 24);
            Point plate3 = new Point((int)_startPosX + 28, (int)_startPosY + 42);
            Point plate4 = new Point((int)_startPosX + 84, (int)_startPosY + 44);
            Point plate5 = new Point((int)_startPosX + 104, (int)_startPosY + 40);
            Point plate6 = new Point((int)_startPosX + 114, (int)_startPosY + 28);
            Point plate7 = new Point((int)_startPosX + 120, (int)_startPosY);
            Point[] PlateForm1 = { plate1, plate2, plate3 };
            Point[] PlateForm2 = { plate3, plate4, plate5, plate6, plate7 };
            Point[] FillPlate = { plate1, plate3, plate7 };
            g.DrawCurve(pen, PlateForm1);
            g.DrawCurve(pen, PlateForm2);
            g.DrawLine(pen, plate1, plate7);
            g.FillPolygon(brush, PlateForm1);
            g.FillPolygon(brush, PlateForm2);
            g.FillPolygon(brush, FillPlate);
            //якорь
            g.FillEllipse(brWh, (int)_startPosX + 27, (int)_startPosY + 10, 13, 13);
            g.DrawEllipse(pen, (int)_startPosX + 27, (int)_startPosY + 10, 13, 13);
            g.DrawEllipse(pen, (int)_startPosX + 31, (int)_startPosY + 14, 6, 6);
            g.DrawEllipse(pen, (int)_startPosX + 32, (int)_startPosY + 12, 4, 2);
            g.DrawEllipse(pen, (int)_startPosX + 28, (int)_startPosY + 15, 2, 4);
            g.DrawEllipse(pen, (int)_startPosX + 37, (int)_startPosY + 15, 2, 4);
            g.DrawEllipse(pen, (int)_startPosX + 32, (int)_startPosY + 29, 4, 4);
            g.DrawEllipse(pen, (int)_startPosX + 26, (int)_startPosY + 24, 3, 6);
            g.DrawEllipse(pen, (int)_startPosX + 40, (int)_startPosY + 24, 3, 6);
            g.DrawRectangle(pen, (int)_startPosX + 28, (int)_startPosY + 25, 12, 3);
            g.DrawRectangle(pen, (int)_startPosX + 33, (int)_startPosY + 20, 3, 10);
            g.FillRectangle(brWh, (int)_startPosX + 27, (int)_startPosY + 26, 14, 2);
            g.FillRectangle(brWh, (int)_startPosX + 34, (int)_startPosY + 21, 2, 10);
            //каюты
            brush = new SolidBrush(DopColor);
            Point CabinPoint1 = new Point((int)_startPosX + 10, (int)_startPosY);
            Point FillCabinPoint1 = new Point((int)_startPosX + 18, (int)_startPosY + 1);
            Point CabinPoint2 = new Point((int)_startPosX + 26, (int)_startPosY - 14);
            Point CabinPoint3 = new Point((int)_startPosX + 84, (int)_startPosY - 13);
            Point CabinPoint4 = new Point((int)_startPosX + 105, (int)_startPosY - 10);
            Point CabinPoint5 = new Point((int)_startPosX + 114, (int)_startPosY);
            Point FillCabinPoint5 = new Point((int)_startPosX + 106, (int)_startPosY + 1);
            Point[] fillCabin1 = { FillCabinPoint1, CabinPoint2, CabinPoint3, CabinPoint4, FillCabinPoint5 };
            g.FillClosedCurve(brush, fillCabin1);
            Point[] drawCabin1 = { CabinPoint1, CabinPoint2, CabinPoint3, CabinPoint4, CabinPoint5 };
            g.DrawCurve(pen, drawCabin1);
            g.DrawEllipse(pen, (int)_startPosX + 42, (int)_startPosY - 10, 8, 8);
            g.FillEllipse(brWh, (int)_startPosX + 42, (int)_startPosY - 10, 8, 8);
            g.DrawEllipse(pen, (int)_startPosX + 61, (int)_startPosY - 9, 7, 7);
            g.FillEllipse(brWh, (int)_startPosX + 61, (int)_startPosY - 9, 7, 7);
            g.DrawEllipse(pen, (int)_startPosX + 80, (int)_startPosY - 8, 6, 6);
            g.FillEllipse(brWh, (int)_startPosX + 80, (int)_startPosY - 8, 6, 6);
        }
    }
}
