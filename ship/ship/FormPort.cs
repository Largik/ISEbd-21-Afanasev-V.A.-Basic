using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace ship
{
    public partial class FormPort : Form
    {
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        private readonly Port<DefaultShip> _port;
        private DefaultShip _lastShip;
        public FormPort()
        {
            InitializeComponent();
            _port = new Port<DefaultShip>(pictureBoxPort.Width, pictureBoxPort.Height);
            Draw();
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxPort.Width, pictureBoxPort.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _port.Draw(gr);
            pictureBoxPort.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать корабль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonParkingShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                { 
                    var boat = new DefaultShip(100, 1000, dialog.Color, dialogDop.Color);
                    boat.SetPosition(_port.XShip, _port.YShip, pictureBoxPort.Width, pictureBoxPort.Height);
                    if (_port._placeFree > 0)
                    {
                        _lastShip = _port + boat;
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Порт переполнен");
                    }
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать теплоход"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMotorShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var mBoat = new MotorShip(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
                    mBoat.SetPosition(_port.XShip, _port.YShip, pictureBoxPort.Width, pictureBoxPort.Height);
                    if (_port._placeFree > 0)
                    {
                        _lastShip = _port + mBoat;
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Порт переполнен");
                    }
                }
            }
        }

        private void buttonTakeShip_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(maskedTextBoxPlaceShip.Text))
            {
                try
                {
                    int index = Convert.ToInt32(maskedTextBoxPlaceShip.Text);
                    var ship = _port - index;

                    if (ship != null)
                    {
                        FormShip form = new FormShip();
                        form.SetShip(ship);
                        form.ShowDialog();

                        _port.takeShip(index);
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Место в порту с данным индексом пустое");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Место в данном порту с данным индексом отсутсвует");
                }
            }
            else
            {
                MessageBox.Show("Введите индекс места в порту");
            }
        }
    }
}