using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TicTac
{
    public partial class Form1 : Form
    {
        Button[,] btn;//Array of buttons

        int[,] GameField;//Array with 1 and -1. 1-X, -1-O

        int N = 3;//Size Game Field
        int number_turn = 0; //Turn sum
        string Turn = "X";//priority of turn

        int ScoreX = 0;//number of Player_X wins
        int ScoreO = 0;//number of Player_O wins

        Label Query;//Shows sequence of move

        public Form1()//Constructor Main Window
        {
            InitializeComponent();


            //Button responsible for Start New Game 
            { 
                Start_Game.Text = "Новая Игра";
                Start_Game.Size = new Size(75, 50);
            }

            //Transform Form Settings
            {
                MaximumSize = new Size(500, 250);
                MinimumSize = new Size(500, 250);
                Name = "TicTacToe";
                Text = "TicTacToe";
            }

            GameField = new int[N, N];//Create Array

            {
                Query = new Label();//Create instance of Label
                                    //Transform Settings
                Query.Text = "Ходят " + Turn;
                Controls.Add(Query);//Add component to the Form
                Query.Location = new Point(50, 150);//Transform Location
            }

            //Create, Add and transform components "Button"          
            {
                btn = new Button[N, N];
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        btn[i, j] = new Button();
                        btn[i, j].Name = i.ToString() + j.ToString();
                        btn[i, j].Size = new Size(50, 50);
                        btn[i, j].Location = new Point(50 * i, 50 * j);
                        btn[i, j].BringToFront();
                        btn[i, j].Click += Button_Click;//Click EventHandler
                        Controls.Add(btn[i, j]);
                    }
                }
            }

        }

        private void Button_Click(object sender, EventArgs e)//Event "Click Button" in Array of buttons
        {
            Button btn = (Button)sender;//Downcast
            number_turn++;
            int X = btn.Location.X / btn.Width;//Coordinate X
            int Y = btn.Location.Y / btn.Height;//Coordinate Y

            if (Turn == "X")
            {
                btn.BackgroundImage = Properties.Resources.Cross;//Add picture from resources to Button
                btn.BackgroundImageLayout = ImageLayout.Zoom;//centering picture
                // btn.BackColor = Color.Red;
                btn.Enabled = false;
                Turn = "O";//Change sequence of move
                GameField[X, Y] = 1;
                Query.Text = "Ходят " + Turn;//Write whoose turn
            }
            else
            {
                btn.BackgroundImage = Properties.Resources.Zero;
                btn.BackgroundImageLayout = ImageLayout.Zoom;
                //btn.BackColor = Color.Black;
                Turn = "X";
                btn.Enabled = false;
                GameField[X, Y] = -1;
                Query.Text = "Ходят " + Turn;
            }

           // Checking
            if (UnitedCheck() == "X")
            {
                ScoreX++;
                label_scoreX.Text = ScoreX.ToString();
                ClearField();
            }
            else if (UnitedCheck() == "O")
            {
                ScoreO++;
                label_scoreO.Text = ScoreO.ToString();
                ClearField();
            }
            else if (number_turn == N * N)//If all buttons are pressed
            {
                MessageBox.Show("Ничья", "Ничья");
                ClearField();
            }

        }
        string UnitedCheck()
        {
            if (CheckHoriz() == "X" ||
                CheckVert() == "X" ||
                CheckDiag() == "X")
            {
                return "X";
            }
            if (CheckHoriz() == "O" ||
                CheckVert() == "O" ||
                CheckDiag() == "O")
            {
                return "O";
            }
            return "0";
        }
        string CheckHoriz()
        {
            if ((GameField[0, 0] == 1 && GameField[0, 1] == 1 && GameField[0, 2] == 1) ||
                (GameField[1, 0] == 1 && GameField[1, 1] == 1 && GameField[1, 2] == 1) ||
                (GameField[2, 0] == 1 && GameField[2, 1] == 1 && GameField[2, 2] == 1))
            {
                return "X";
            }
            if ((GameField[0, 0] == -1 && GameField[0, 1] == -1 && GameField[0, 2] == -1) ||
                (GameField[1, 0] == -1 && GameField[1, 1] == -1 && GameField[1, 2] == -1) ||
                (GameField[2, 0] == -1 && GameField[2, 1] == -1 && GameField[2, 2] == -1))
            {

                return "O";
            }
            return "0";
        }
        string CheckVert()
        {
            if ((GameField[0, 0] == 1 && GameField[1, 0] == 1 && GameField[2, 0] == 1) ||
                (GameField[0, 1] == 1 && GameField[1, 1] == 1 && GameField[2, 1] == 1) ||
                (GameField[0, 2] == 1 && GameField[1, 2] == 1 && GameField[2, 2] == 1))
            {
                return "X";
            }
            if ((GameField[0, 0] == -1 && GameField[1, 0] == -1 && GameField[2, 0] == -1) ||
                (GameField[0, 1] == -1 && GameField[1, 1] == -1 && GameField[2, 1] == -1) ||
                (GameField[0, 2] == -1 && GameField[1, 2] == -1 && GameField[2, 2] == -1))
            {
                return "O";
            }
            return "0";
        }
        string CheckDiag()
        {
            if ((GameField[0, 0] == 1 && GameField[1, 1] == 1 && GameField[2, 2] == 1) ||
                (GameField[0, 2] == 1 && GameField[1, 1] == 1 && GameField[2, 0] == 1))
            {
                return "X";
            }
            if ((GameField[0, 0] == -1 && GameField[1, 1] == -1 && GameField[2, 2] == -1) ||
                (GameField[0, 2] == -1 && GameField[1, 1] == -1 && GameField[2, 0] == -1))
            {
                return "O";
            }
            return "0";
        }

        void ClearField()//Clear Game Field. Return all System settings to buttons and Clear Array of values
        {
            number_turn = 0;
            Thread.Sleep(1000);//Stopping programm on 1 sec
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    btn[i, j].Enabled = true;
                    btn[i, j].BackgroundImage = null;
                    // btn[i, j].BackColor = Color.Empty;
                    GameField[i, j] = 0;
                }
            }
        }

        private void Start_Game_Click(object sender, EventArgs e)//Event pressing the button "New Game" 
        {
            ClearField();//Run cleaning method
            
            //Clear score of players
            ScoreO = 0;
            ScoreX = 0;

            label_scoreO.Text = "0";
            label_scoreX.Text = "0";
        }
    }
}
