using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            
            // Display title as the C# console calculator app.           
            Common.DisplayTitle();

            while (!endApp)
            {
                Calculation calculation = new Calculation();
                calculation.SetNumInput1(Constants.GetNULL());
                calculation.SetNumInput2(Constants.GetNULL());
                calculation.SetResult(0);

                // Ask the user to type the first number.
                Common.DisplayFirstNumber();
                calculation.SetNumInput1(Console.ReadLine());
                calculation.ConvertToDouble(CalCode.one);

                // Ask the user to choose an operator.
                Common.DisplayFirstOp();
                calculation.SetOp(Console.ReadLine());

                // Ask the user to type the second number.
                Common.DisplayAnotherNumber();
                calculation.SetNumInput2(Console.ReadLine());
                calculation.ConvertToDouble(CalCode.another);

                // Calculate
                calculation.DoOperation();

                    bool endformula = false;
                    while (!endformula)
                    {
                        Common.DisplayAnotherOp();
                        calculation.SetOp(Console.ReadLine());
                        if (calculation.GetOp() == OperationCode.e)
                        {
                            calculation.SetResult(calculation.GetCleanNum1());
                            break;
                        }

                        // Ask the user to type the second number.
                        Common.DisplayAnotherNumber();
                        calculation.SetNumInput2(Console.ReadLine());
                        calculation.ConvertToDouble(CalCode.another);

                        // Calculate
                        calculation.DoOperation();
                }
                //Display Result
                Common.DisplayResult(calculation.GetResult());

                // Wait for the user to respond before closing.
                Common.DisplayEndApp();
                
                if (Console.ReadLine() == Constants.GetENDAPP()) endApp = true;
                Common.DisplayNewLine();
            }
            return;
        }
    }
}

