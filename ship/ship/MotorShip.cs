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
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { protected set; get; }
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
            Color dopColor, bool cabin, bool line, bool pipe) :
            base(maxSpeed, weight, mainColor, 120, 58)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            DopColor = dopColor;
            Cabin = cabin;
            Line = line;
            Pipe = pipe;
        }
        /// <summary>
        /// Отрисовка корабля
        /// </summary>
        /// <param name="g"></param>
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            SolidBrush brWh = new SolidBrush(Color.White);
            if (Pipe)
            {
                SolidBrush brush = new SolidBrush(DopColor);
                //труба1
                g.DrawRectangle(pen, (int)_startPosX + 45, (int)_startPosY - 41,  16,  40);
                g.FillRectangle(brush, (int)_startPosX + 45, (int)_startPosY - 41,  16,  40);
                //труба2
                g.DrawRectangle(pen, (int)_startPosX + 70, (int)_startPosY - 36,  14,  40);
                g.FillRectangle(brush, (int)_startPosX + 70, (int)_startPosY - 36,  14,  40);
                //труба3
                g.DrawRectangle(pen, (int)_startPosX + 92, (int)_startPosY - 30,  10,  40);
                g.FillRectangle(brush, (int)_startPosX + 92, (int)_startPosY - 30,  10,  40);
            }
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
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
    }
}