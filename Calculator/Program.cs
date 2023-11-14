using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: create a function that takes parameters and returns desired mathematical solution
            int num1, num2;
            int result = 0;
            string operation;

            Console.WriteLine("Starting calculator application...");
            Console.WriteLine("Enter first number:");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose operation type:");
            //Console.WriteLine("[addition, subtraction, multiplication, division]");
            Console.WriteLine("[ + , - , * , / ]");

            // adding ?? creates a nullifying string; prevents warning of assigning null character to a string
            operation = Console.ReadLine() ?? "";  

            if (operation == "+")
            {
                result = num1 + num2;
            }else if (operation == "-")
            {
                result = num1 - num2;
            }else if (operation == "*")
            {
                result = num1 * num2;
            }else if (operation == "/")
            {
                result = num1 / num2;
            }else
            {
                Console.WriteLine("invalid entry");
            }

            Console.WriteLine("Result: " + result);
            Console.WriteLine("Ending calculator application...");
            Console.ReadKey();
        }
    }
}