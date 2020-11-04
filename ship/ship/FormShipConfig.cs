using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ship
{
    public partial class FormShipConfig : Form
    {
        /// <summary>
        /// Переменная-выбранная машина
        /// </summary>
        Ship ship = null;
        private event ShipDelegate eventAddShip;
        public FormShipConfig()
        {
            InitializeComponent();
            foreach (var item in groupBoxColors.Controls)
            {
                if (item is Panel)
                {
                    ((Panel)item).MouseDown += panelColor_MouseDown;
                }
            }
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        /// <summary>
        /// Отрисовать корабль
        /// </summary>
        private void DrawShip()
        {
            if (ship != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxTypeShip.Width, pictureBoxTypeShip.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.SetPosition(5, 50, pictureBoxTypeShip.Width, pictureBoxTypeShip.Height);
                ship.DrawTransport(gr);
                pictureBoxTypeShip.Image = bmp;
            }
        }
        public void AddEvent(ShipDelegate ev)
        {
            if (eventAddShip == null)
            {
                eventAddShip = new ShipDelegate(ev);
            }
            else
            {
                eventAddShip += ev;
            }
        }
        private void labelDefaultShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelDefaultShip.DoDragDrop(labelDefaultShip.Name, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelMotorShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelMotorShip.DoDragDrop(labelMotorShip.Name, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void panelShip_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "labelDefaultShip":
                    ship = new DefaultShip((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "labelMotorShip":
                    ship = new MotorShip((int)numericUpDownMaxSpeed.Value,(int)numericUpDownWeight.Value, Color.White, Color.Black, checkBoxCabin.Checked, checkBoxLines.Checked, checkBoxPipes.Checked);
                    break;
            }
            DrawShip();
        }
        private void panelShip_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            ship?.SetMainColor((Color)(e.Data.GetData(typeof(Color))));
            DrawShip();
        }
        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddShip?.Invoke(ship);
            Close();
        }
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship is MotorShip)
            {
                MotorShip SHip = (MotorShip)ship;

                SHip.SetDopColor((Color)(e.Data.GetData(typeof(Color))));
                DrawShip();
            }
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            ((Panel)sender).DoDragDrop(((Panel)sender).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }
    }
}