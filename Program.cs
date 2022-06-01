using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            long num1;
            long num2;
            string symbol;
            long result;
            string continuation;

            do
            {
                Console.Write("Enter first number: ");
                num1 = Convert.ToInt64(Console.ReadLine());

                Console.Write("Enter second number: ");
                num2 = Convert.ToInt64(Console.ReadLine());

                Console.Write("What do you want to perform? \n" +
                    "Press: \n" +
                    "+ for addition \n" +
                    "- for substraction \n" +
                    "* for multiplication \n" +
                    "/ for division \n" +
                    ": ");
                symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("The addition of the numbers {0} and {1} is {2} \n *Press enter to continue", num1, num2, result);
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("The substraction of the numbers {0} and {1} is {2} \n Press enter to continue", num1, num2, result);
                        break;

                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("The multiplication of the numbers {0} and {1} is {2} \n Press enter to continue", num1, num2, result);
                        break;

                    case "/":
                        result = num1 / num2;
                        Console.WriteLine("The division of the numbers {0} and {1} is {2} \n Press enter to continue", num1, num2, result);
                        break;

                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
                Console.ReadLine();
                Console.Write("Do you want to continue? \n" +
                    "Press (y) for yes and (n) for no \n" +
                    ": ");
                continuation = Console.ReadLine();
            }
            while (continuation == "y" || continuation == "Y" || continuation == "(y)");
            
        }
    }
}
