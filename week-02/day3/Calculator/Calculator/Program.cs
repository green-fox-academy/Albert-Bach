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
            Int32 num1;
            Int32 num2;

            char operand;
            
            float answer;

            Console.WriteLine("Please type in the expression:");
            string solution = Console.ReadLine();
            //num1 = Convert.ToInt32((solution[0]));
            num1 = int.Parse(solution[0].ToString());
            operand = solution[1];
            num2 = int.Parse(solution[2].ToString());

            switch (operand)

            {
                case '-':
                    answer = num1 - num2;

                    break;

                case '+':
                    answer = num1 + num2;

                    break;

                case '*':
                    answer = num1 * num2;

                    break;

                case '/':
                    answer = num1 /num2;

                    break;

                case '%':
                    answer = num1 / num2 * 100;

                    break;

                default:

                    answer = 0;

                    break;

            }

            Console.WriteLine(num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());
            Console.ReadLine();

        }
    }
}
