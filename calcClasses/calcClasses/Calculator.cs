using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;
using CalcClasses;
using calcClasses.Helpers;

namespace CalcClasses
{
    public class Calculator: InputValidators
    {
        // members
        public int Left { get; set; }
        public int Right { get; set; }
        public string Operator { get; set; }
        ArrayList memory = new ArrayList();


        public Calculator()
        {
           
        }

        public Calculator(int Left, int Right, string Operator) : this()
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
                    Console.WriteLine("Error please check inputs of Calculate");
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

        public int getPrevious(int res)
        {

            int value = memory.IndexOf(res);

            if (value >= 0)
            {

                int temp = (int)value;
                var conv = memory[temp];
                int final = (int)conv;
                return final;
            }
            else
            {
                throw new System.ArgumentException("no result");
            }
        }
        public int storeResult(int num)
        {
            if (num != 0)
            {

                memory.Add(num);

                string temp = "Stored";
                foreach (var item in memory)
                {
                    Console.WriteLine(item);
                }
                return num;
            }
            else
                throw new NullReferenceException("No result present ");
        }


        //public bool isValidNumber(int number)
        //{

        //    string temp = string.Empty;
        //    if (!String.IsNullOrEmpty(number.ToString()))
        //    {

        //        temp = number.ToString();
        //    }


        //    bool isNumeric = Regex.IsMatch(temp, @"(\+|-)?\d+");

        //    if (isNumeric)
        //    {
        //        return isNumeric;
        //    }
        //    else
        //    {
        //        throw new System.ArgumentException("Your Input is not a number");
        //    }

        //}


        //public bool isValidOpr(string oper)
        //{
        //    bool isOpr = false;
        //    if (oper != null)
        //    {
        //        isOpr = Regex.IsMatch(oper, @"[+\-\\/\*]");
        //    }
        //    else if (isOpr)
        //    {
        //        return isOpr;
        //    }
        //    else
        //    {
        //        throw new System.ArgumentException("Your input is not an operator");
        //    }
        //    Console.WriteLine("Operator ={0}", isOpr);
        //    return isOpr;
        //}

    }
}
