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
    public partial class Form1 : Form
    {
        Random R = new Random();
        public Form1()
        {
            InitializeComponent();

            Size = new Size(Properties.Resources.MenuWall.Width, Properties.Resources.MenuWall.Height);

            Help.Click += Help_Click;

            Musics.play_sound();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            lvl Lvl1 = new lvl();
            Lvl1.ShowDialog();
            

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Music_CheckedChanged(object sender, EventArgs e)
        {
            if (Music.Checked==true)
            {
                Musics.sound_on();
                Music.Text = "Music on";
            }
            else
            {
                Musics.sound_off();
                Music.Text = "Music off";
            }
        }
    }
}
