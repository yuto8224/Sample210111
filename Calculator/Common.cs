using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Common
    {
        public static void DisplayTitle()
        {
            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");
        }
        public static void DisplayFirstNumber()
        {
            // Display title as the C# console calculator app.
            Console.Write("Type a number, and then press Enter: ");
        }
        public static void DisplayFirstOp()
        {
            // Ask the user to choose an operator.
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");
        }
        public static void DisplayAnotherNumber()
        {
            // Ask the user to type the second number.
            Console.Write("Type another number, and then press Enter: ");
        }
        public static void DisplayAnotherOp()
        {
            // Ask the user to choose an operator.
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\t= - Equal");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");
        }
        public static void DisplayResult(double result)
        {
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Your result: {0:0.##}\n", result);
            Console.WriteLine("\n"); // Friendly linespacing.
        }
        public static void DisplayEndApp()
        {
            Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
        }
        public static void DisplayNewLine()
        {
            Console.WriteLine("\n");
        }
        public static void DisplayCheckMsg()
        {
            Console.Write("This is not valid input. Please enter an integer value: ");
        }
        public static void DisplayErrMsg(Exception e)
        {
            Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
        }
        public static void DisplayOpeCheckMsg()
        {
            Console.Write("This is not valid Operation. Please enter an operation one more: ");
        }

    }
}
