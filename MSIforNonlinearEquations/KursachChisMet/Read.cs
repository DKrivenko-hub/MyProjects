using System.Collections.Generic;
using System.IO;

namespace KursachChisMet
{
    internal class Read
    {
        private string Path;//путь к файлу
        private List<string> SystemEq;//Динамический массив для системы
        private int Rank;//Ранг
        private List<string> ArgumentLeft;
        private List<string>[] ArgumentsRight;
        private string[] ArgumentsR;
        private string[] RightSide;
        double[] InitialAppr;

        public Read(string Path)//Конструктор
        {
            this.Path = Path;

            SystemEq = new List<string>();
            ArgumentLeft = new List<string>();
            CountRank();
            ArgumentsRight = new List<string>[Rank];
            ArgumentsR = new string[Rank];
            RightSide = new string[Rank];
            InitialAppr = new double[Rank];
            for (int i = 0; i < Rank; i++)
            {
                ArgumentsRight[i] = new List<string>();
            }
            ReadSystem();//Запуск метода чтения файла 
        }

        //
        // Свойства для возращений значения
        //
        public double[] ReturnInitialApprox => InitialAppr;
        public string[] ReturnResult
        {
            get
            {
                string[] Result = new string[SystemEq.Count];
                SystemEq.CopyTo(Result);
                return Result;
            }
        }
        public int ReturnRank => Rank;
        public string[] ReturnArgumentLeft
        {
            get
            {
                string[] Result = new string[SystemEq.Count];
                ArgumentLeft.CopyTo(Result);
                return Result;
            }
        }
        public string[] ReturnArgRightArr => ArgumentsR;
        public List<string>[] ReturnArgRightTwoArr => ArgumentsRight;

        public string[] ReturnRightSide
        {
            get
            {
                for (int i = 0; i < Rank; i++)
                {
                    RightSide[i] = SystemEq[i].Substring(3);
                }
                return RightSide;
            }
        }

        private void ReadSystem()//Метод считывающий файл
        {
            using (StreamReader rd = new StreamReader(Path))//Инициализация потока для считывания данных
            {
                string line;
                int position = 0;
                int z = 0;
                string[] separate = new string[2];
                while ((line = rd.ReadLine()) != null)
                {
                    separate = line.Split(';');
                    InitialAppr[z] = double.Parse(separate[1]);
                    z++;
                    SystemEq.Add(separate[0]);
                    ArgumentLeft.Add(string.Format("X{0}", position + 1));
                    for (int i = 2; i < separate[0].Length; i++)
                    {
                        if (separate[0][i] == 'X')
                        {
                            if (ArgumentsRight[position].Contains(separate[0][i].ToString() + separate[0][i + 1].ToString()) == false)
                            {
                                ArgumentsRight[position].Add(separate[0][i].ToString() + line[i + 1].ToString());
                                i++;
                            }
                        }
                    }
                    ArgumentsRight[position].Sort();
                    position++;
                }
                Convert();
            }
        }

        private void CountRank()
        {
            using (StreamReader rd = new StreamReader(Path))
            {
                string line;
                while ((line = rd.ReadLine()) != null)
                {
                    Rank++;
                }
            }
        }

        private void Convert()
        {
            string storage = null;
            for (int i = 0; i < Rank; i++)
            {
                for (int j = 0; j < ArgumentsRight[i].Count; j++)
                {
                    storage = storage + string.Format("{0},", ArgumentsRight[i][j]);
                }
                storage = storage.Remove(storage.Length - 1);
                ArgumentsR[i] = storage;
                storage = null;
            }
        }

    }
}
