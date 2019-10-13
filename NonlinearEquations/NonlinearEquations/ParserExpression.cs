using System;

static class ParserExpression
{

    public static string ToPoland(string inputY)
    {
        string[] symbols = { "sin", "cos", "tg", "ctg", "exp", "ln", "(", ")", "+", "-", "*", "/", "^" };
        int[] symbol_rate = { 20, 20, 20, 20, 20, 20, 0, 1, 5, 5, 10, 10, 15 };
        Stack OperationStack = new Stack();

        string output = ""; int i = 0; bool NotOperation = false;
        while (i < inputY.Length)
        {
            string temp = inputY[i].ToString();
            bool fl = false; int j = 0;
            while (j < symbols.Length && !(fl))
            {
                if (symbols[j][0] == temp[0])
                {
                    if (symbols[j].Length == 1)
                        fl = true;
                    else
                    {
                        string operation = inputY.Substring(i, 2);
                        switch (operation)
                        {
                            case "si":
                                temp = "sin";
                                i += 2;
                                break;
                            case "co":
                                temp = "cos";
                                i += 2; j = 1;
                                break;
                            case "tg":
                                temp = "tg";
                                i++;
                                break;
                            case "ctg":
                                temp = "ctg";
                                i += 2; j = 3;
                                break;
                            case "ln":
                                temp = "ln";
                                i++;
                                break;
                            case "ex":
                                temp = "exp";
                                i += 2;
                                break;
                        }
                        fl = true;
                        break;
                    }
                }
                j++;
            }

            if (fl)
            {
                if (NotOperation)
                {
                    output += "}";
                    NotOperation = !(NotOperation);
                }
                switch (temp)
                {
                    case "(":
                        OperationStack.Push(temp);
                        break;
                    case ")":
                        while ((string)OperationStack.Peek() != "(")
                            output = output + "{" + OperationStack.Pop() + "}";
                        OperationStack.Pop();

                        if (OperationStack.Count != 0)
                        {
                            if (OperationStack.Peek().ToString().Length != 1)
                                output = output + "{" + OperationStack.Pop() + "}";
                        }
                        break;
                    default:
                        if (OperationStack.Count == 0)
                        {
                            OperationStack.Push(temp);
                            break;
                        }
                        string head = (string)OperationStack.Peek();
                        int head_rate = -100;
                        int k = 0;
                        while (k < symbols.Length)
                        {
                            if (symbols[k] == head)
                            {
                                head_rate = symbol_rate[k];
                                break;
                            }
                            k++;
                        }
                        if (symbol_rate[j] > head_rate)
                            OperationStack.Push(temp);
                        else
                        {
                            output = output + "{" + OperationStack.Pop() + "}";
                            OperationStack.Push(temp);
                        }
                        break;
                }


            }
            else
            {
                if (!(NotOperation))
                {
                    output += "{";
                    NotOperation = !(NotOperation);
                }
                output += temp;
            }
            i++;
        }
        if (NotOperation)
        {
            NotOperation = !(NotOperation);
            output += "}";
        }
        while (OperationStack.Count != 0)
            output = output + "{" + OperationStack.Pop() + "}";
        return output;

    }

    public static string ParameterReplace(string[] param, double[] param_value, string InPoland)
    {

        for (int i = 0; i < param.Count(); i++)
        {
            InPoland = InPoland.Replace(param[i], param_value[i].ToString());
        }
        InPoland = InPoland.Replace("PI", Math.PI.ToString());
        return InPoland;
    }

    public static double FunctionValue(string expression)
    {
        double value = 0;
        Stack OperationStack = new Stack();
        string[] operands = expression.Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < operands.Count(); i++)
        {
            double temp;
            if (Double.TryParse(operands[i], out temp))
                OperationStack.Push(temp);
            else
                switch (operands[i])
                {
                    case "sin":
                        temp = Math.Sin((double)(OperationStack.Pop()));
                        OperationStack.Push(temp);
                        break;
                    case "cos":
                        temp = Math.Cos((double)(OperationStack.Pop()));
                        OperationStack.Push(temp);
                        break;
                    case "tg":
                        temp = Math.Tan((double)(OperationStack.Pop()));
                        OperationStack.Push(temp);
                        break;
                    case "ctg":
                        temp = 1 / Math.Tan((double)(OperationStack.Pop()));
                        OperationStack.Push(temp);
                        break;
                    case "ln":
                        temp = Math.Log((double)(OperationStack.Pop()));
                        OperationStack.Push(temp);
                        break;
                    case "exp":
                        temp = Math.Exp((double)(OperationStack.Pop()));
                        OperationStack.Push(temp);
                        break;
                    case "+":
                        temp = (double)(OperationStack.Pop());
                        temp += (double)(OperationStack.Pop());
                        OperationStack.Push(temp);
                        break;
                    case "-":
                        temp = -(double)(OperationStack.Pop());
                        if (OperationStack.Count != 0)
                            temp += (double)(OperationStack.Pop());
                        OperationStack.Push(temp);
                        break;
                    case "/":
                        temp = (double)(OperationStack.Pop());
                        temp = (double)(OperationStack.Pop()) / temp;
                        OperationStack.Push(temp);
                        break;
                    case "*":
                        temp = (double)(OperationStack.Pop());
                        temp *= (double)(OperationStack.Pop());
                        OperationStack.Push(temp);
                        break;
                    case "^":
                        temp = (double)(OperationStack.Pop());
                        temp = Math.Pow((double)(OperationStack.Pop()), temp);
                        OperationStack.Push(temp);
                        break;
                    case "PI":
                        OperationStack.Push(Math.PI);
                        break;
                    case "E":
                        OperationStack.Push(Math.E);
                        break;
                    default:
                        //Обработка ошибки (считанное значение не число и не знак операции - вычисление невозможно)
                        break;
                }

        }
        value = (double)(OperationStack.Peek());
        return value;
    }

}
