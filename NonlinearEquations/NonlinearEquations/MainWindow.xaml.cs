using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Threading;

namespace NonlinearEquations
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double InitialApprox;
        double leftBoard;
        double rightBoard;

        double PreviousX;
        double CurrentX;

        string Function;
        string DeriveFunction;

        int[] Counter;
        double[] Answer;

        public MainWindow()
        {
            InitializeComponent();

            Counter = new int[2];
            Answer = new double[2];
        }

        private void button_TurnOn_Click(object sender, RoutedEventArgs e)
        {
            //string Argument = textbox_InpArgFunct.Text;

            InitialApprox = double.Parse(textbox_approx.Text);

            leftBoard = double.Parse(textbox_leftBorder.Text);
            rightBoard = double.Parse(textbox_rightBorder.Text);

            MSI();
            PreviousX = 0;
            CurrentX = 0;
            NewtonsMethod();

            Results res = new Results(Answer[0], Answer[1], Counter[0], Counter[1]);
            res.ShowDialog();
        }

        void MSI()
        {
            Function = textbox_InpFunct_MSI.Text;
            DeriveFunction = textbox_InpDerFunct_MSI.Text;

            MathParser.Parser p = new MathParser.Parser();
            PreviousX = InitialApprox;

            string DerfunctionLeft = ReplaceVariable(DeriveFunction, "x", leftBoard);
            string DerfunctionRight = ReplaceVariable(DeriveFunction, "x", rightBoard);
            double Max = Math.Abs(Math.Max(p.ResultReturn(DerfunctionLeft), p.ResultReturn(DerfunctionRight)));

            if (Max >= 1)
            {
                return;
            }

            double q = Max;
            string function;
            double Eps = 0.0001;
            double Apost = (1 - q) * Eps / q;
            Counter[0] = 0;

            while (Math.Abs(PreviousX - CurrentX) > Eps)
            {
                PreviousX = CurrentX;
                function = ReplaceVariable(Function, "x", PreviousX);
                CurrentX = p.ResultReturn(function);
                Counter[0]++; 
            }
            Answer[0] = CurrentX;
        }


        void NewtonsMethod()
        {

            Function = textbox_InpFunct_Newt.Text;
            DeriveFunction = textbox_InpDerFunct_Newt.Text;

            double Eps = 0.0001;
            MathParser.Parser p = new MathParser.Parser();
            CurrentX = InitialApprox;

            string derfunction;
            string function;

            Counter[1] = 0;

            while (Math.Abs(PreviousX - CurrentX) >= Eps)
            {
                PreviousX = CurrentX;
                derfunction = ReplaceVariable(DeriveFunction, "x", PreviousX);
                function = ReplaceVariable(Function, "x", PreviousX);
                CurrentX = PreviousX - p.ResultReturn(function) / p.ResultReturn(derfunction);
                Counter[1]++;
                if (Counter[1] > 10000)
                {
                    MessageBox.Show("Итераций больше 10000. Остановка программы. Текущий результат = " + CurrentX.ToString());
                    Thread.Sleep(2000);
                    Close();
                    return;
                }
            }
            Answer[1] = CurrentX;

        }       

        string ReplaceVariable(string function, string variable, double number)
        {
            function = function.Replace(variable, number.ToString());
            return function;
        }
    }
}
