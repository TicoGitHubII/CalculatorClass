using calcClasses.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcClasses
{

    // refactored to Stack, Interface impementation, Model seperation of concerns
    public class CalculatorRefactor : InputValidators{

        public int Left { get; set; }
        public int Right { get; set; }
        public string Operator { get; set; }
        Stack Recall = new Stack();


        public CalculatorRefactor()
        {
            Console.WriteLine("Default Constructor Invoked");

        }

    
        public CalculatorRefactor(int Left, int Right, string Operator) 
        {
            this.Left = Left;
            this.Right = Right;
            this.Operator = Operator;

        }

        public int Calculate(int left, int right, string oper)
        {
            int Result = 0;

            switch (oper)
            {
                case "+":
                    Result = left + right;

                    break;
                case "-":
                    Result = left - right;
                    break;
                case "/":
                    if (right != 0)
                    {
                        Result = left / right;
                    }
                    else
                    {
                        Console.WriteLine("Can't divide by Zero {0}/{1}", left, right);
                    }
                    break;
                case "*":
                    Result = left * right;
                    break;
                default:
                    Console.WriteLine("error please check inputs of Calculate");
                    break;
            }
            return Result;
        }


        public void clear()
        {
            Left = 0;
            Right = 0;
            Operator = null;
        }

        
        public string getPrevious()
        {
             string Last = Recall.Pop().ToString();

             return Last;
        }

        public void setRecall(int res)
        {
            bool isNum = isValidNumber(res);
            if (isNum)
            {
                Recall.Push(res);
            }
            else
                throw new NullReferenceException("No result present ");
        }


    



    }
}

