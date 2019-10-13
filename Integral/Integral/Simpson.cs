using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;

namespace Integral
{
    internal class Simpson
    {
        private Function f;
        Function derF;

        private double[] FunctionX;
        private double[] FunctionMidX
            ;
        private double exactValue;

        private double[] X;
        private double[] MiddleX;
        List<double> R;
        private double a, b;

        public Simpson(Function f,Function derF, double LeftBoard, double RightBoard, double exactValue, int N)
        {
            this.f = f;
            this.derF = derF;

            this.exactValue = exactValue;

            a = LeftBoard;
            b = RightBoard;

            X = new double[N+1];
            MiddleX = new double[N ];

            FunctionX = new double[N+1];
            FunctionMidX = new double[N ];

            Result = new List<double>();
            R = new List<double>();

            double h = (b - a) / N;

            Nodes(h);
            Result.Add(MethodSimpson(N, h));
        }

        public Simpson(Function f, Function derF, double LeftBoard, double RightBoard, double exactValue, params int[] N)
        {
            this.f = f;
            this.derF = derF;

            this.exactValue = exactValue;

            a = LeftBoard;
            b = RightBoard;

            Result = new List<double>();
            R = new List<double>();

            double h;
            for (int i = 0; i < N.Length; i++)
            {
                h = (b - a) / (N[i]);

                X = new double[N[i]+1];
                MiddleX = new double[N[i]];

                FunctionX = new double[N[i]+1 ];
                FunctionMidX = new double[N[i]];

                Nodes(h);
                Result.Add(MethodSimpson(N[i], h));
            }
        }

        public List<double> Result { get; }
        public double[] MistakeRung => EvaluationRung();
        public double[] MistakeTheory
        {
            get
            {
                double[] res = new double[R.Count];
                R.CopyTo(res);
                return res;
            }
        }
        public double[] MistakePractice => EvaluationPractice();

        private double MethodSimpson(int N, double h)
        {
            double simpson = 0;
            for (int i = 1; i <= N; i++)
            {
                simpson = simpson + (FunctionX[i - 1] + 4 * FunctionMidX[i - 1] + FunctionX[i]);
            }
            simpson = simpson * h / 6;
            R.Add(EvaluationTheory(h));
            return simpson;
        }

        private void Nodes(double h)
        {
            double x = a;
            for (int i = 0; i < X.Length; i++)
            {
                X[i] =x;
                FunctionX[i] = f.calculate(X[i]);
                x += h;
            }
            for (int i = 0; i < MiddleX.Length; i++)
            {
                MiddleX[i] = (X[i] + X[i + 1]) / 2;
                FunctionMidX[i] = f.calculate(MiddleX[i]);
            }
        }

        private double[] EvaluationRung()
        {
            double[] res = new double[Result.Count-1];
            for (int i = 0; i < Result.Count-1; i++)
            {
                res[i] = Math.Abs(Result[i] - Result[i+1]);
            }
            return res;
        }
        private double EvaluationTheory(double h)
        {
           
            double Max = 0;
            for (int i = 0; i < X.Length; i++)
            {
                double df = Math.Abs(derF.calculate(X[i]));
                if (df > Max)
                {
                    Max = df;
                }
            }
            double res;
                res = (b - a) * Math.Pow(h,4) * Max / 2880;
            return res;
        }

        double[]  EvaluationPractice()
        {
            double[] res = new double[Result.Count];
            for (int i = 0; i < Result.Count; i++)
            {
                res[i] = Math.Abs(exactValue - Result[i]);
            }
            return res;
        }
    }
}
