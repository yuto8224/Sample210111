using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Calculation
    {
        string numInput1;
        string numInput2;
        double cleanNum1;
        double cleanNum2;
        double result;
        OperationCode op;

        public void ConvertToDouble(CalCode flag)
        {
            switch(flag)
            {
                case CalCode.one:
                    while (!double.TryParse(numInput1, out cleanNum1))
                    {
                        Common.DisplayCheckMsg();
                        numInput1 = Console.ReadLine();
                    }
                    break;
                case CalCode.another:
                    while (!double.TryParse(numInput2, out cleanNum2))
                    {
                        Common.DisplayCheckMsg();
                        numInput2 = Console.ReadLine();
                    }
                    break;
                default:
                    break;
            }
        }

        public void DoOperation()
        {
            try
            {    
                // Use a switch statement to do the math.
                switch (op)
                {
                    case OperationCode.a:
                        cleanNum1 = cleanNum1 + cleanNum2;
                        break;
                    case OperationCode.s:
                        cleanNum1 = cleanNum2 - cleanNum2;
                        break;
                    case OperationCode.m:
                        cleanNum1 = cleanNum1 * cleanNum2;
                        break;
                    case OperationCode.d:
                        // Ask the user to enter a non-zero divisor.
                        if (cleanNum2 != 0)
                        {
                            cleanNum1 = cleanNum1 / cleanNum2;
                        }
                        break;
                    // Return text for an incorrect option entry.
                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                Common.DisplayErrMsg(e);
            }
        }

        //アクセサ
        public string GetNumInput1()
        {
            return numInput1;
        }

        public string GetNumInput2()
        {
            return numInput2;
        }

        public double GetResult()
        {
            return result;
        }

        public double GetCleanNum1()
        {
            return cleanNum1;
        }

        public double GetCleanNum2()
        {
            return cleanNum2;
        }

        public OperationCode GetOp()
        {
            return op;
        }

        public void SetNumInput1(string arg)
        {
            numInput1 = arg;
        }

        public void SetNumInput2(string arg)
        {
            numInput2 = arg;
        }

        public void SetResult(double num)
        {
            result = num;
        }

        public void SetCleanNum1(double num)
        {
            cleanNum1 = num;
        }

        public void SetCleanNum2(double num)
        {
            cleanNum2 = num;
        }

        public void SetOp(string arg)
        {
            int val = Constants.CodeConvert(arg);
            while (!Enum.IsDefined(typeof(OperationCode), val))
            {
                Common.DisplayOpeCheckMsg();
                arg = Console.ReadLine();
                val = Constants.CodeConvert(arg);
            }
            op = (OperationCode)val;
        }
    }
}
