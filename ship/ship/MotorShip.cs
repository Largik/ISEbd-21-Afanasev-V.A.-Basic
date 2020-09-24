using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ship
{
    public class MotorShip : DefaultShip
    {
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _maxHeight;
        /// <summary>
        /// Количество кают
        /// </summary>
        public bool Cabin { private set; get; }
        /// <summary>
        /// Полоса
        /// </summary>
        public bool Line { private set; get; }
        /// <summary>
        /// Наличие труб
        /// </summary>
        public bool Pipe { private set; get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес корабля</param>
        /// /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="cabin">Количество кают</param>
        /// <param name="line">Наличие полосы</param>
        /// <param name="pipe">Наличие труб</param>
        /// <param name="mainColor">Основной цвет корабля</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        public MotorShip(int maxSpeed, float weight, Color mainColor, 
            Color dopColor, bool cabin, bool line, bool pipe):
            base(maxSpeed, weight, mainColor, 120, 58)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Cabin = cabin;
            Line = line;
            Pipe = pipe;
            if (Pipe)
            {
                _maxHeight = 45;
            }
            else
            {
                _maxHeight = 20;
            }
        }  
        /// <summary>
        /// Отрисовка корабля
        /// </summary>
        /// <param name="g"></param>
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
           //Brush brush = new SolidBrush(MainColor);
            SolidBrush brWh = new SolidBrush(Color.White);
            base.DrawTransport(g);
            if (Line)
            {
                Point line1 = new Point((int)_startPosX + 4, (int)_startPosY + 10);
                Point line2 = new Point((int)_startPosX + 66, (int)_startPosY + 14);
                Point line3 = new Point((int)_startPosX + 118, (int)_startPosY + 14);
                Point line4 = new Point((int)_startPosX + 8, (int)_startPosY + 16);
                Point line5 = new Point((int)_startPosX + 66, (int)_startPosY + 20);
                Point line6 = new Point((int)_startPosX + 116, (int)_startPosY + 20);
                Point[] linePoints1 = { line1, line2, line3 };
                Point[] linePoints2 = { line4, line5, line6 };
                g.DrawCurve(pen, linePoints1);
                g.DrawCurve(pen, linePoints2);
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
            }       
            if (Cabin)
            { 
                g.DrawEllipse(pen, (int)_startPosX + 23, (int)_startPosY - 10, 8, 8);
                g.FillEllipse(brWh, (int)_startPosX + 23, (int)_startPosY - 10, 8, 8);
                g.DrawEllipse(pen, (int)_startPosX + 42, (int)_startPosY - 10, 8, 8);
                g.FillEllipse(brWh, (int)_startPosX + 42, (int)_startPosY - 10, 8, 8);
                g.DrawEllipse(pen, (int)_startPosX + 61, (int)_startPosY - 9, 7, 7);
                g.FillEllipse(brWh, (int)_startPosX + 61, (int)_startPosY - 9, 7, 7);
                g.DrawEllipse(pen, (int)_startPosX + 80, (int)_startPosY - 8, 6, 6);
                g.FillEllipse(brWh, (int)_startPosX + 80, (int)_startPosY - 8, 6, 6);
                g.DrawEllipse(pen, (int)_startPosX + 99, (int)_startPosY - 7, 5, 5);
                g.FillEllipse(brWh, (int)_startPosX + 99, (int)_startPosY - 7, 5, 5);
            }
            if (Pipe)
            {
                //труба1
                Point pipe11 = new Point((int)_startPosX + 44, (int)_startPosY - 15);
                Point pipe12 = new Point((int)_startPosX + 45, (int)_startPosY - 41);
                Point pipe13 = new Point((int)_startPosX + 55, (int)_startPosY - 44);
                Point pipe14 = new Point((int)_startPosX + 64, (int)_startPosY - 40);
                Point pipe15 = new Point((int)_startPosX + 64, (int)_startPosY - 14);
                Point pipe16 = new Point((int)_startPosX + 45, (int)_startPosY - 33);
                Point pipe17 = new Point((int)_startPosX + 55, (int)_startPosY - 36);
                Point pipe18 = new Point((int)_startPosX + 64, (int)_startPosY - 32);
                Point pipe19 = new Point((int)_startPosX + 45, (int)_startPosY - 29);
                Point pipe110 = new Point((int)_startPosX + 55, (int)_startPosY - 32);
                Point pipe111 = new Point((int)_startPosX + 64, (int)_startPosY - 28);
                g.DrawLine(pen, pipe11, pipe12);
                Point[] PIPE1 = { pipe12, pipe13, pipe14 };
                Point[] PIPE12 = { pipe16, pipe17, pipe18 };
                Point[] PIPE13 = { pipe19, pipe110, pipe111 };
                g.DrawCurve(pen, PIPE1);
                g.DrawLine(pen, pipe14, pipe15);
                g.DrawCurve(pen, PIPE12);
                g.DrawCurve(pen, PIPE13);
                //труба2
                Point pipe21 = new Point((int)_startPosX + 67, (int)_startPosY - 14);
                Point pipe22 = new Point((int)_startPosX + 68, (int)_startPosY - 36);
                Point pipe23 = new Point((int)_startPosX + 76, (int)_startPosY - 39);
                Point pipe24 = new Point((int)_startPosX + 84, (int)_startPosY - 35);
                Point pipe25 = new Point((int)_startPosX + 84, (int)_startPosY - 13);
                Point pipe26 = new Point((int)_startPosX + 68, (int)_startPosY - 30);
                Point pipe27 = new Point((int)_startPosX + 76, (int)_startPosY - 33);
                Point pipe28 = new Point((int)_startPosX + 84, (int)_startPosY - 29);
                Point pipe29 = new Point((int)_startPosX + 68, (int)_startPosY - 26);
                Point pipe210 = new Point((int)_startPosX + 76, (int)_startPosY - 29);
                Point pipe211 = new Point((int)_startPosX + 84, (int)_startPosY - 25);
                g.DrawLine(pen, pipe21, pipe22);
                Point[] PIPE2 = { pipe22, pipe23, pipe24 };
                Point[] PIPE22 = { pipe26, pipe27, pipe28 };
                Point[] PIPE23 = { pipe29, pipe210, pipe211 };
                g.DrawCurve(pen, PIPE2);
                g.DrawLine(pen, pipe24, pipe25);
                g.DrawCurve(pen, PIPE22);
                g.DrawCurve(pen, PIPE23);
                //труба3
                Point pipe31 = new Point((int)_startPosX + 87, (int)_startPosY - 13);
                Point pipe32 = new Point((int)_startPosX + 88, (int)_startPosY - 30);
                Point pipe33 = new Point((int)_startPosX + 95, (int)_startPosY - 32);
                Point pipe34 = new Point((int)_startPosX + 101, (int)_startPosY - 29);
                Point pipe35 = new Point((int)_startPosX + 101, (int)_startPosY - 12);
                Point pipe36 = new Point((int)_startPosX + 88, (int)_startPosY - 26);
                Point pipe37 = new Point((int)_startPosX + 95, (int)_startPosY - 28);
                Point pipe38 = new Point((int)_startPosX + 101, (int)_startPosY - 25);
                Point pipe39 = new Point((int)_startPosX + 88, (int)_startPosY - 23);
                Point pipe310 = new Point((int)_startPosX + 95, (int)_startPosY - 25);
                Point pipe311 = new Point((int)_startPosX + 101, (int)_startPosY - 22);
                g.DrawLine(pen, pipe31, pipe32);
                Point[] PIPE3 = { pipe32, pipe33, pipe34 };
                Point[] PIPE32 = { pipe36, pipe37, pipe38 };
                Point[] PIPE33 = { pipe39, pipe310, pipe311 };
                g.DrawCurve(pen, PIPE3);
                g.DrawLine(pen, pipe34, pipe35);
                g.DrawCurve(pen, PIPE32);
                g.DrawCurve(pen, PIPE33);
            }        
        }
    }
}