using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Philosophy
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();

            Bitmap bmp = Properties.Resources.MenuWall;
            Color color = bmp.GetPixel(20, 20);

            Size = new Size(Properties.Resources.MenuWall.Width, Properties.Resources.MenuWall.Height);
            label1.AutoSize = false;
            label1.BackColor = color;

            pictureBox1.BackgroundImage = Properties.Resources.arrow;
            pictureBox1.BackColor = color;

            label2.BackColor = color;

            button2.BackColor = color;

            label2.Text = "Правила \nЯкщо ти потрапив сюди, то нечітко розумієш що робити, або просто тикав по кнопкам.Так як, я сподіваюся, тобі не треба пояснювати де кнопка виходу (в правому верхньому куті), то я розповім що ти повинен робити в грі. Твоя задача зібрати всі питання, а точніше відповісти на них правильно ну або неправильно. Але потрібно бути уважним, так як твої життя не нескінченні і можуть закінчитися. Я сподіваюся у тебе все вийде, Хай щастить! ";

            button2.Click += Button2_Click;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
