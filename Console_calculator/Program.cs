using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string operand;
            ConsoleKeyInfo choice;
            float answer;
            

            Console.WriteLine("\t\t\tCalculator Application\n");
            while (true)
            {
                Console.Write("Please enter the first integer: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter an operand (+, -, /, *): ");
                operand = Console.ReadLine();

                Console.Write("Please enter the second integer: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                

                switch (operand)
                {
                    case "-":
                        answer = num1 - num2;
                        break;
                    case "+":
                        answer = num1 + num2;
                        break;
                    case "/":
                        answer = num1 / num2;
                        break;
                    case "*":
                        answer = num1 * num2;
                        break;
                    case "%":
                        answer = num1 % num2;
                        break;
                    case "^":
                        answer = num1 ^ num2;
                        break;
                 default:
                 answer = 0;
                break;
            }

            Console.WriteLine(num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());
                Console.WriteLine("\n\n Do You Want To Continue? Press (Y/N)");
                choice = Console.ReadKey();
                
                Console.Clear();
            }

        }
    }
}
