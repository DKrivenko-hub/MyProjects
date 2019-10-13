using MathParser;
using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KursachChisMet
{
    public partial class Form1 : Form
    {
        private Dictionary<string, double> NewX;
        private Dictionary<string, double> CurrentX;

        private string[] SystemEquations;//Массив для Системы уравнений
        private string[] ArgumentLeft;//Массив аргументов слева в уравнении
        private string[] ArgumentsRight;//Масиив аргументов справа 
        private string[] RightSide;//Массив со всей правой стороной
        private List<string>[] ArgRight;//Список аргуметов справа

        private string path;//Путь к файлу, где записаны уравнения

        private double Epsilon;//Епсилон
        double[] StartInitial;

        private int SystemRank;//Ранг системы

        private Function f;//Создание экземпляра класса для парсинга уравнений в системе
        private Expression ex;

        private int koef = 0;
        private int numbers_of_Steps = 0;

        public Form1()
        {
            InitializeComponent();
            string text = "           Некторые правила для ввода Систем нелинейных уравнений \n1.Каждое уравнение следует записать с новой строки в текстовом документе\n 2.Переменные в уравнениях обозначать как X1, X2, X3.... .Обязательно 'Х' и с большой буквы, иначе программа будет работать некорректно \n3.Обязательно задать значение Епсилон.Если этого не сделать будет происходить зависание или ошибка при выполнении \n4.Проверить систему нелинейных уравнений на сходимость что бы не получилось зависания программы \n5.Корректно указывать путь к файлу и число Епсион(файл должен быть разрешения.txt";
            toolTip.UseFading = true;
            toolTip.SetToolTip(label_help, text);
            toolTip.AutoPopDelay = 500000000;

        }
        //Обработка нажатия на кнопку
        private void button1_Click(object sender, EventArgs e)
        {
            numbers_of_Steps = 0;
            try
            {
                path = textBox_FileAdress.Text;//Определение пути к файлу
                Epsilon = double.Parse(textBox_Eps.Text);//Порядок точности

                Read rd = new Read(path);//Инициализация класса и считывания системы

                SystemEquations = rd.ReturnResult;//Возращение результатов считывания: Система уравнений
                SystemRank = rd.ReturnRank;//Возращение результатов считывания: Ранг системы уравнений
                ArgumentLeft = rd.ReturnArgumentLeft;//Возращение результатов считывания: Аргументы левой части вида Xi=Фi(X1,X2,...Xn)
                ArgumentsRight = rd.ReturnArgRightArr;////Возращение результатов считывания: Аргументы правой части вида Xi=Фi(X1,X2,...Xn)
                ArgRight = rd.ReturnArgRightTwoArr;

                RightSide = rd.ReturnRightSide;

                //StartInitial = double.Parse(textBox_Initial.Text);
                StartInitial = new double[SystemRank];
                StartInitial = rd.ReturnInitialApprox;
                InitializeDict();

                MSI();
            }
            catch (FormatException)
            {
                MessageBox.Show("Неправильный формат входных данных. Попробуйте ещё раз");//Обработка ошибки на неправильный формат ввоодимых данных
            }
        }

        private void MSI()//Метод простых итераций
        {
            string expression = null;
            Parser prs = new Parser();

            while (!StopProcess())
            {
                numbers_of_Steps++;
                ReplaceValues();
                for (int index = 1, j = 0; index < SystemRank + 1; index++, j++)
                {
                    expression = "f(" + ArgumentsRight[j] + ")=" + RightSide[j];
                    double res = (f = new Function(expression)).calculate(Find(j));

                    if (double.IsNaN(res))
                    {

                        richTextBox_result.AppendText("Итерационный процесс был остановлен\n");
                        break;
                    }
                    NewX[string.Format("X{0}", index)] = res;
                }
            }
            Output();
        }

        private string Replace(int index)
        {
            string function = RightSide[index];

            return function;
        }
        private void Output()//Вывод найденных значений на форму
        {
            for (int i = 1; i < SystemRank + 1; i++)
            {
                richTextBox_result.AppendText(string.Format("{0}={1}\n", string.Format("X{0}", i), NewX[string.Format("X{0}", i)].ToString()));
            }
            richTextBox_result.AppendText(numbers_of_Steps.ToString() + "\n");
        }

        private void InitializeDict()//Инициализация словарей и заполнение их значениями
        {
            NewX = new Dictionary<string, double>();
            CurrentX = new Dictionary<string, double>();
            for (int i = 0; i < SystemRank; i++)
            {
                NewX.Add(ArgumentLeft[i], 1);
                CurrentX.Add(ArgumentLeft[i], StartInitial[i]);
            }
        }

        private double[] Find(int index)//Поиск нужных значений для вычисления функции по индексу. Возрат массива найденных значений
        {
            double[] array = new double[ArgRight[index].Count];

            int i = 0, j = 0;
            foreach (string c in CurrentX.Keys)
            {

                if (i >= ArgRight[index].Count)
                {
                    return array;
                }
                if (c == ArgRight[index][i])
                {
                    array[j] = CurrentX[c];
                    j++;
                    i++;
                }
            }
            return array;
        }

        private string Find(string line, int index)//Поиск нужных значений для вычисления функции по индексу. Возрат массива найденных значений
        {
            double[] array = new double[ArgRight[index].Count];

            int i = 0, j = 0;
            foreach (string c in CurrentX.Keys)
            {
                if (i >= ArgRight[index].Count)
                {
                    break;
                }
                if (c == ArgRight[index][i])
                {
                    array[j] = CurrentX[c];
                    j++;
                    i++;
                }
            }
            for (i = 0; i < array.Length; i++)
            {
                line = line.Replace(ArgRight[index][i].ToString(), array[i].ToString());
            }
            return line;
        }

        private void ReplaceValues()//Присваивание значений из Словаря NewX в словарь CurrentX
        {
            foreach (string el in NewX.Keys)
            {
                CurrentX[el] = NewX[el];
            }
        }

        private bool StopProcess()//Критерий остановки итерационного процесса
        {
            int k = 0;
            for (int i = 1; i < SystemRank + 1; i++)
            {
                if (Math.Abs(NewX[string.Format("X{0}", i)] - CurrentX[string.Format("X{0}", i)]) < Epsilon)
                {
                    k++;
                }

            }

            if (k == SystemRank)
            {
                return true;
            }

            return false;
        }
    }

}
