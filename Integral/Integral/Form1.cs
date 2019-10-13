    using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace Integral
{
    public partial class Form1 : Form
    {
        private string Function;
        private string NewFunction;

        private Expression exactValue;
        private double[] MistakeRung;
        private double[] MistakeTheory;
        double[] MistakePractice;
        private double a, b, h;
        private int[] AutoSize;

        private Function F;
        private Function DerF;

        private int N;

        private List<double> Result;

        private Color[] colorList;

        private bool IsCustomers = false;

        //   ZedGraph

        public Form1()
        {
            InitializeComponent();

            Function = "FUNCTION";

            AutoSize = new int[3];
            int k = 1;
            for (int i = 0; i < 3; i++)
            {
                AutoSize[i] = 10 * k;
                k *= 2;
            }

            colorList = new Color[] { Color.Red, Color.SeaGreen, Color.Tan, Color.Yellow, Color.Green, Color.Black, Color.Coral, Color.Cyan, Color.Firebrick, Color.Indigo, Color.LimeGreen };

        }

        private void button_DoIt_Click(object sender, EventArgs e)
        {

            radioButton_QuantityAuto.Enabled = false;
            radioButton_QuantityUsers.Enabled = false;

            try
            {

                NewFunction = textBox_Function.Text;

                exactValue = new Expression(textBox_ExactVal.Text);

                a = double.Parse(textBox_LeftBoard.Text);
                b = double.Parse(textBox_RightBoard.Text);

                NewFunction = string.Format("{0}{1}{2}{3}{4}{5}", "f", "(", "X", ")", "=", NewFunction);
                string Derfun = textBox_der.Text;
                Derfun = string.Format("{0}{1}{2}{3}{4}{5}", "f", "(", "X", ")", "=", Derfun);

                F = new Function(NewFunction);
                DerF = new Function(Derfun);
                Result = new List<double>();

                if (NewFunction != Function)
                {
                    DrawFunction();
                }

                if (IsCustomers == false)
                {
                    if (textBox_Quantity.Text == null)
                    {
                        MessageBox.Show("Поле ввода пустое. Попробуйте ещё раз", "Ошибка");
                        return;
                    }

                    N = int.Parse(textBox_Quantity.Text);
                    Simpson simps = new Simpson(F, DerF, a, b, exactValue.calculate(), N);
                    Result = simps.Result;
                    MistakeRung = simps.MistakeRung;
                    MistakeTheory = simps.MistakeTheory;
                    MistakePractice = simps.MistakePractice;
                }
                else
                {
                    Simpson simps = new Simpson(F,DerF ,a, b, exactValue.calculate(),AutoSize);
                    Result = simps.Result;
                    MistakeRung = simps.MistakeRung;
                    MistakeTheory = simps.MistakeTheory;
                    MistakePractice = simps.MistakePractice;
                }

                Output();

                radioButton_QuantityAuto.Enabled = true;
                radioButton_QuantityUsers.Enabled = true;

                Function = NewFunction;
            }
            catch (FormatException)
            {
                MessageBox.Show("Неправильный формат вводимых данных. Повторите ошибку", "Ошибка");
                radioButton_QuantityAuto.Enabled = true;
                radioButton_QuantityUsers.Enabled = true;
            }
        }

        private void Output()
        {
            if (!IsCustomers)
            {
                richTextBox_Result.AppendText(string.Format("{0} при N={1} : {2} \n ", "Результат", N.ToString(), Math.Round(Result[0], 6).ToString()));
              //  richTextBox_Result.AppendText(string.Format("{0}={1} \n", "Практическая погрешность", MistakePractice[0].ToString()));
                richTextBox_Result.AppendText(string.Format("{0}={1} \n", "Теоретическая погрешность ", MistakeTheory[0].ToString()));
                richTextBox_Result.AppendText("\n");
            }
            else
            {
                for (int i = 0; i < Result.Count; i++)
                {
                    richTextBox_Result.AppendText(string.Format("{0} при N={1}:{2} \n", "Результат", AutoSize[i].ToString(), Math.Round(Result[i], 6).ToString()));
                  //  richTextBox_Result.AppendText(string.Format("{0}={1} \n", "Практическая погрешность", MistakePractice[i].ToString()));
                    richTextBox_Result.AppendText(string.Format("{0}={1} \n", "Теоретическая погрешность ", MistakeTheory[i].ToString()));
                    richTextBox_Result.AppendText("\n");
                }
            }
            for (int i = 0; i < MistakeRung.Length; i++)
            {
                richTextBox_Result.AppendText(string.Format("{0}{1}{2}", "Погрешность Рунге: ", MistakeRung[i], ";"));
                richTextBox_Result.AppendText("\n");
            }

        }

        private void DrawFunction()
        {

            GraphPane pane = zedGraphControl_function.GraphPane;

            pane.Title.Text = "Функция";

            PointPairList list = new PointPairList();
            h = 0.01;
            for (double X = a; X <= b; X += h)
            {
                list.Add(X, f(X));
            }
            Random rnd = new Random();

            LineItem function = pane.AddCurve(NewFunction, list, colorList[rnd.Next(0, colorList.Length)], SymbolType.None);
            zedGraphControl_function.AxisChange();
            zedGraphControl_function.Invalidate();
        }

        private void radioButton_QuantityUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (!IsCustomers)
            {
                textBox_Quantity.Enabled = false;
                IsCustomers = true; ;
            }
            else
            {
                textBox_Quantity.Enabled = true;
                IsCustomers = false;
            }
        }

        private double f(double X)
        {
            return F.calculate(X);
        }
    }
}
