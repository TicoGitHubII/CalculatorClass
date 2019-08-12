using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcClasses;

namespace calcClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            bool reset = false;
            bool isValidInput = false;
            int result = 0;
            Calculator calc = new Calculator();


            do
            {
                Console.Write("Enter a number :");
                
                int input = Convert.ToInt32(Console.ReadLine());

                isValidInput = calc.isValidNumber(input);
                if (isValidInput)
                {
                    calc.Left = input;
                }
                isValidInput = false;

                Console.Write("Enter  2nd number :");
                int input2 = Convert.ToInt32(Console.ReadLine());

                isValidInput = calc.isValidNumber(input2);
                if (isValidInput)
                {
                    calc.Right = input2;
                }
                isValidInput = false;

                Console.WriteLine("Enter Operator ");
                string inputOpr = Console.ReadLine();

                isValidInput = calc.isValidOpr(inputOpr);
                if (isValidInput)
                {
                    calc.Operator = inputOpr;
                }

                result = calc.Calculate(calc.Left, calc.Right, calc.Operator);

                calc.storeResult(result);

                Console.WriteLine("Result {0} {1} {2} = {3}", calc.Left, calc.Operator, calc.Right, result);


                Console.WriteLine("Recall Last?  n or y");
                string recall = Console.ReadLine();
                if (recall == "y")
                {
                    Console.WriteLine("recall {0}", calc.getPrevious(result));
                }
                else
                {

                    goto Start;
                }

     Start:
                Console.WriteLine("Start Over?  n or y");
                string res = Console.ReadLine();
                reset = res.Equals("y");
                if (res == "y")
                { Console.Clear(); }
                else
                {
                    continue;
                }
            } while (reset);

            Console.WriteLine(calc.storeResult(result));
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();


        }
    }
}

