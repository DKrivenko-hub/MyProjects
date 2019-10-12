using System;
using System.Drawing;
using System.Windows.Forms;

namespace курсач_2
{
    public partial class Form1 : Form
    {
        //объявление переменных
        private VerticalProgressBar PrBar;
        private int i = 0;
        private static Timer clock;
        private static Button New_Game;
        private static int[,] Array;
        private static string[,] b_num;
        private static Button[,] btn;
        private static Random R = new Random();
        private static int N = 10;
        private static int s = 0;
        private static Label lbl;
        private static Label score;
        private static Label number;
        public Form1()
        {
            InitializeComponent();

            //Правила
            MessageBox.Show("Перед Вами логическая математическая игра-головоломка. Ваша задача очистить игровое поле заполненное цифрами за ограниченный промежуток времени. Чтобы убрать цифры, Вам нужно будет считать их суммы. В правом верхнем углу игрового поля будет указано число. Ваша задача кликнуть левой кнопкой мыши на 2 цифры, которые дадут в сумме это число. После каждого правильного ответа требуемое число будет меняться.");

            //Интерфейс  
            Button Info = new Button();
            Controls.Add(Info);
            Info.Location = new Point(550, 150);
            Info.Text = "Rules";
            Info.Size = new Size(100, 50);
            Info.ForeColor = Color.Navy;
            Info.Font = new System.Drawing.Font("Comic Sans MS", 10);

            Info.Click += Info_Click;

            New_Game = new Button
            {
                Size = new Size(100, 50),
                Location = new Point(550, 50),
                Text = "New Game"
            };
            New_Game.Click += New_Game_Click;
            New_Game.ForeColor = Color.Navy;
            New_Game.Font = new System.Drawing.Font("Comic Sans MS", 10);
            Controls.Add(New_Game);

            //Задание свойств формы
            StartPosition = FormStartPosition.CenterScreen;//центрирование формы
            BackgroundImage = Properties.Resources.derevo;//фон
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(700, 500);//максимальный размер формы
            MinimumSize = new System.Drawing.Size(700, 500);//минимальный размер формы

            //создание элемента управление VerticalProgressBar
            PrBar = new VerticalProgressBar();
            Controls.Add(PrBar);
            PrBar.Size = new Size(30, 200);
            PrBar.Location = new Point(450, 80);
            PrBar.Enabled = true;
            PrBar.Maximum = 1200;
            PrBar.Value = 0;

            //создание элемента управления таймер
            clock = new Timer
            {
                Enabled = true
            };
            clock.Tick += Clock_Tick;
            clock.Start();

            //Создания элемента управления Label для значения суммы
            number = new Label();
            Controls.Add(number);
            number.Size = new Size(50, 50);
            number.Location = new Point(440, 5);
            number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            number.Text = (R.Next(2, 16).ToString());
            number.Font = new System.Drawing.Font("Comic Sans MS", 20);
            number.BackColor = Color.Transparent;
            number.ForeColor = Color.Navy;

            //Создания элемента управления Label "Score"
            score = new Label();
            Controls.Add(score);
            score.Text = "Score";
            score.BackColor = Color.Transparent;
            score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            score.Font = new System.Drawing.Font("Comic Sans MS", 15);
            score.Location = new Point(440, 300);
            score.Size = new Size(75, 50);
            score.ForeColor = Color.Navy;

            ////Создания элемента управления Label для записи очков игрока
            lbl = new Label();
            Controls.Add(lbl);
            lbl.Location = new Point(440, 350);
            lbl.BackColor = Color.Transparent;
            lbl.Text = s.ToString();
            lbl.ForeColor = Color.Navy;
            lbl.Font = new System.Drawing.Font("Comic Sans MS", 20);
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lbl.Size = new Size(50, 50);

            ////Создания элемента управления Button
            btn = new Button[N, N];
            Array = new int[N, N];//Объявление массива из 0 и 1
            b_num = new string[N, N];//объявления массива для записи значений кнопок

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    b_num[i, j] = R.Next(0, 11).ToString();
                    btn[i, j] = new Button
                    {
                        Name = i.ToString() + j.ToString(),
                        Text = b_num[i, j]
                    };
                    Controls.Add(btn[i, j]);
                    btn[i, j].Size = new Size(40, 40);
                    btn[i, j].Location = new Point(40 * i, 40 * j);
                    btn[i, j].Click += Form1_Click;
                }
            }
        }

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Перед Вами логическая математическая игра-головоломка. Ваша задача очистить игровое поле заполненное цифрами за ограниченный промежуток времени. Чтобы убрать цифры, Вам нужно будет считать их суммы. В правом верхнем углу игрового поля будет указано число. Ваша задача кликнуть левой кнопкой мыши на 2 цифры, которые дадут в сумме это число. После каждого правильного ответа требуемое число будет меняться.");
        }

        private void New_Game_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 Frm2 = new Form1();
            Frm2.Show();
            PrBar.Enabled = true;
            PrBar.Value = 0;
        }

        //Обработка события Нажатия на кнопку
        private void Form1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Enabled = false;
            b.BackColor = Color.Aqua;
            int btn_X = b.Location.X / b.Width;
            int btn_Y = b.Location.Y / b.Height;


            if (Check_Array_with_0_1(Array) == true)
            {
                Array_with_0_1(b.Text, btn_X, btn_Y);
            }
            if (Check_Array_with_0_1(Array) == true)
            {
                if (Check_Location(btn_X, btn_Y) == true)
                {
                    lbl.Text = (s = s + 10).ToString();
                    number.Text = R.Next(0, 16).ToString();
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            Array[i, j] = 0;
                        }
                    }
                }
            }
            //Check_for_Exeption(int.Parse(b.Text));
        }

        //Проверка важных элментов игры
        public static int[,] Array_with_0_1(string Text, int X, int Y)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (int.Parse(number.Text) % 2 == 0)
                    {
                        Array[X, Y] = 0;
                    }
                    if (i == X && j == Y)
                    {
                        Array[i, j] = 0;
                    }
                    if (int.Parse(b_num[i, j]) == Numb_which_u_can_press(Text))////////////////////////
                    {
                        Array[i, j] = 1;
                    }
                    else
                    {
                        Array[i, j] = 0;
                    }
                }
            }
            return Array;
        }

        public static bool Check_Array_with_0_1(int[,] Array)
        {
            int s_0 = 0;
            int s_1 = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (Array[i, j] == 1)
                    {
                        s_1++;
                    }
                    if (Array[i, j] == 0)
                    {
                        s_0++;
                    }
                }
            }
            if (s_1 >= 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static int Numb_which_u_can_press(string Text)////////////////////////
        {
            int number_wich_u_can_press = int.Parse(number.Text) - int.Parse(Text);
            return number_wich_u_can_press;
        }

        public static bool Check_Location(int X, int Y)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (Array[i, j] == 1 && X == i && Y == j)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Часики
        private void Clock_Tick(object sender, EventArgs e)
        {
            PrBar.Value++;
            i++;
            if (i == 1200)
            {
                clock.Stop();
                clock.Enabled = false;

                //if (clock.Enabled == false)
                //{
                //    Form form = new Form();
                //    form.BackgroundImage = Properties.Resources.yvozhenie;
                //    form.Show();
                //    form.MaximumSize = new System.Drawing.Size(384, 518);
                //    form.MinimumSize = new System.Drawing.Size(384, 518);

                //}
            }
        }//////////////////////////////

        //Обработка исключений
        //public static void Check_for_Exeption(int Text)///////////////////////////
        //{
        //    int num = Numb_which_u_can_press(Text.ToString());
        //    int koef = 0;
        //    int koef1 = 0;
        //    for (int i = 0; i < N; i++)
        //    {
        //        for (int j = 0; j < N; j++)
        //        {
        //            if (b_num[i, j] == Text.ToString())
        //            {
        //                b_num[i, j] = 0.ToString();
        //                koef++;
        //            }
        //            //if (Array_with_0_1[i,j]==0 )
        //            //{
        //            //    koef1++;
        //            //}
        //        }
        //    }

        //    if (koef == 100 || koef1 == 100 || Text != num || clock.Enabled == false)
        //    {
        //        Messege_Box();
        //    }
        //}

        //    public static void Messege_Box()
        //    {
        //        MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
        //        DialogResult result;
        //        result = MessageBox.Show("Game Over           Повторить игру или закрыть приложение?", "Что же делать дальше? ", buttons);
        //        if (result == DialogResult.Retry)
        //        {
        //            //Hide();
        //            //Form1 Frm2 = new Form1();
        //            //Frm2.Show();
        //        }
        //        else
        //        {
        //            //Form1.Close();
        //        }
        //    }///////////////////////
        //}

        //Класс для создания вертикального ProgressBar
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
}