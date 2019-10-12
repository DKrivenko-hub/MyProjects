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
    public partial class lvl : Form
    {
        Random R = new Random();

        int X;
        int Y;
        int way;//  направление движения змеи: 1 - вверх, 2 - вправо, 3 - вниз, 4 - влево
        int QuestsLeft = Settings.numberQuestions-1;

        int[] loc;

        Label[] lbl;

        Bitmap bmp = new Bitmap(Properties.Resources.Mapa, Properties.Resources.Mapa.Width, Properties.Resources.Mapa.Height);
        Bitmap VisibleZone = new Bitmap(Properties.Resources.Mapa.Width, Properties.Resources.Mapa.Height);

        public lvl()
        {
            InitializeComponent();

            KeyDown += Lvl_KeyDown;

            FPS.Start();

            X = 30;
            Y = 30;
            Graphics g = Graphics.FromImage(bmp);
            g.FillEllipse(Brushes.GreenYellow, X, Y, Settings.characterSize, Settings.characterSize);

            loc = new int[Settings.numberQuestions];

            MaximumSize = new Size(1100, 1100);
            MinimumSize = new Size(1100, 1100);

            Map.Image = bmp;
            Map.Size = new Size(bmp.Width, bmp.Height);
            Map.Location = new Point(0, 0);


            for (int y = 0; y < VisibleZone.Height; y++)
            {
                for (int x = 0; x < VisibleZone.Width; x++)
                {
                    VisibleZone.SetPixel(x, y, Color.Black);
                }
            }
            Visible_Zone.Size = new Size(bmp.Width, bmp.Height);
            Visible_Zone.Image = VisibleZone;
            Visible_Zone.Location = new Point(0, 0);
            Visible_Zone.BringToFront();
            DrawVisibleZone(X, Y);

            Visible_Zone.Visible = true;

            Map.Focus();

            lbl = new Label[]{
                label1,
                label2,
                label3,
                label4,
                label5,
                label6,
                label7,
                label8,
                label9,
                label10,
                label11,
                label12,
                label13,
                label14,
                label15,
                label16,
                label17
            };
            for (int i = 0; i < lbl.Length; i++)
            {
                lbl[i].Size = new Size(Settings.SizeBox, Settings.SizeBox);
                lbl[i].Visible = false;
            }
            DrawingTaskBox(Settings.numberQuestions, lbl.Length, loc);

        }
        //Прорисовка видимой зоні вокруг персонажа
        void DrawVisibleZone(int X, int Y)
        {
            int x = X;
            int y = Y;
            
                int VisiblePixl = Settings.VisibleRadius * Settings.gridSize;
                for (x = X - Settings.VisibleRadius + 1; x < X + VisiblePixl; x++)
                {
                    for (y = Y - Settings.VisibleRadius + 1; y < Y + VisiblePixl; y++)
                    {

                        if ((x - X) * (x - X) + (y - Y) * (y - Y) <= Settings.VisibleRadius * Settings.VisibleRadius && x>=0 && y>=0 && x<bmp.Width && y<bmp.Height)
                        {
                            if (bmp.GetPixel(x, y) != Color.GreenYellow)
                            {
                                VisibleZone.SetPixel(x, y, bmp.GetPixel(x, y));
                            }
                        }
                    }
                }
            
               
        }

        //Прорисовка заданий
        void DrawingTaskBox(int number, int length, int[] loc)
        {
            Brush br = Brushes.Yellow;
            Random R = new Random();
            int index = 0;
            int x, y;
            Graphics g = Graphics.FromImage(bmp);

            int i = 0;
            while (i < loc.Length)
            {
                int r = R.Next(0, length);
                if (Search(r, loc) == false)
                {
                    loc[i] = r;
                    i++;
                }
            }
            for (int j = 0; j < number; j++)
            {

                index = loc[j];
                x = lbl[index].Location.X;
                y = lbl[index].Location.Y;
                lbl[index].Visible = false;
                g.FillRectangle(br, x, y, Settings.SizeBox, Settings.SizeBox);
            }
        }
        bool Search(int x, int[] numb)
        {
            for (int i = 0; i < numb.Length; i++)
            {
                if (numb[i] == x)
                {
                    return true;
                }
            }
            return false;
        }

        private void Lvl_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    {
                        way = 2;
                        break;
                    }
                case Keys.Left:
                    {
                        way = 4;
                        break;
                    }
                case Keys.Up:
                    {

                        way = 1;
                        break;
                    }
                case Keys.Down:
                    {
                        way = 3;
                        break;
                    }

            }
        }

        //Подключение заданий
        void TurnOnQuest()
        {
            
            int r = R.Next(0, Texts.Questions.Length);
            Question quest = new Question(Texts.Questions[r][0],
                                     Texts.Questions[r][1],
                                     Texts.Questions[r][2],
                                     Texts.Questions[r][3],
                                     Texts.Questions[r][4],
                                     Texts.Questions[r][5],
                                     Texts.Answer[r]);
            DialogResult dr = quest.ShowDialog();
            if (dr != DialogResult.OK)
            {
                HealthPoint.Value = HealthPoint.Value - Settings.Damage;
                if (HealthPoint.Value == 0)
                {
                    DialogResult result = MessageBox.Show(quest, "Health left you . Do you want Retry?", "Game Over", MessageBoxButtons.RetryCancel);
                    if (result == DialogResult.Cancel)
                    {
                        Close();
                    }
                    else
                    {
                        Close();
                        lvl lvl = new lvl();
                    }

                }
            }
            if (QuestsLeft == 0)
            {
                Close();
            }
            QuestsLeft--;
            
        }///////////////

        //Просмотр клеток перед персонажем
        bool MoveCheck(int x, int y, ref int z)
        {
                for (int i = y; i < y + Settings.characterSize; i++)
                {
                    for (int j = x; j < x + Settings.characterSize; j++)
                    {
                        if (bmp.GetPixel(j, i) == Color.FromArgb(0, 0, 0))
                        {
                            return false;
                        }
                        if (bmp.GetPixel(j, i) == Color.FromArgb(255, 255, 0))
                        {

                            z = 1;
                            return true;
                        }
                    }
                }
                z = 0;
                return true;
            
        }


        private void Lvl1_QuestEvent(object sender)
        {
            Label lb = (Label)sender;
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White, lb.Location.X, lb.Location.Y, Settings.SizeBox, Settings.SizeBox);
            lb.Dispose();
            way = 0;
            TurnOnQuest();
        }

        private void FPS_Tick(object sender, EventArgs e)
        {

            Graphics g = Graphics.FromImage(bmp);
            g.FillEllipse(Brushes.White, X, Y, Settings.characterSize, Settings.characterSize);
            int param = 0;
            switch (way)
            {
                case (1)://вверх
                    {

                        if (MoveCheck(X, Y - Settings.characterSize, ref param) == true)
                        {

                            Y = Y - Settings.Speed;
                            int index = 0;
                            for (int i = 0; i < loc.Length; i++)
                            {
                                index = loc[i];
                                if (Y <= lbl[index].Location.Y &&
                                    Y >= lbl[index].Location.Y &&
                                    X + Settings.characterSize >= lbl[index].Location.X &&
                                    X <= lbl[index].Location.X + Settings.SizeBox && param == 1)
                                {
                                    Lvl1_QuestEvent(lbl[index]);

                                    break;
                                }
                            }
                        }


                        break;
                    }
                case (2)://вправо
                    {

                        if (MoveCheck(X + Settings.characterSize, Y, ref param) == true)
                        {
                            X = X + Settings.Speed;
                            int index = 0;
                            for (int i = 0; i < Settings.numberQuestions; i++)
                            {
                                index = loc[i];
                                if (X + Settings.characterSize >= lbl[index].Location.X &&
                                    X <= lbl[index].Location.X + Settings.SizeBox &&
                                    Y + Settings.characterSize >= lbl[index].Location.Y &&
                                    Y <= lbl[index].Location.Y + Settings.SizeBox && param == 1)
                                {
                                    Lvl1_QuestEvent(lbl[index]);

                                    break;

                                }
                            }
                        }

                        break;
                    }
                case (3)://вниз
                    {


                        if (MoveCheck(X, Y + Settings.characterSize, ref param) == true)
                        {
                            Y = Y + Settings.Speed;
                            int index = 0;
                            for (int i = 0; i < loc.Length; i++)
                            {
                                index = loc[i];
                                if (Y + Settings.characterSize >= lbl[index].Location.Y &&
                                    Y + Settings.characterSize <= lbl[index].Location.Y + Settings.SizeBox &&
                                    X + Settings.characterSize >= lbl[index].Location.X &&
                                    X <= lbl[index].Location.X + Settings.SizeBox && param == 1)
                                {
                                    Lvl1_QuestEvent(lbl[index]);

                                    break;

                                }
                            }
                        }
                        break;
                    }
                case (4)://влево
                    {


                        if (MoveCheck(X - Settings.characterSize, Y, ref param) == true)
                        {
                            X = X - Settings.Speed;
                            int index = 0;
                            for (int i = 0; i < loc.Length; i++)
                            {
                                index = loc[i];
                                if (X <= lbl[index].Location.X + Settings.SizeBox &&
                                    X + Settings.characterSize > lbl[index].Location.X &&
                                    Y + Settings.characterSize >= lbl[index].Location.Y &&
                                    Y <= lbl[index].Location.Y + Settings.SizeBox && param == 1)
                                {
                                    Lvl1_QuestEvent(lbl[index]);

                                    break;
                                }
                            }
                        }
                        break;
                    }
                default:

                    break;
            }


            g.FillEllipse(Brushes.GreenYellow, X, Y, Settings.characterSize, Settings.characterSize);
            Map.Refresh();
            DrawVisibleZone(X, Y);
            Visible_Zone.Refresh();
        }

    }

    public class VerticalProgressBar : ProgressBar
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int PBS_VERTICAL = 0x04;

                CreateParams cp = base.CreateParams;
                cp.Style |= PBS_VERTICAL;
                return cp;
            }
        }
    }
}
