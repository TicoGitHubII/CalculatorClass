using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace calcClasses.Helpers
{
    public class InputValidators : IInputValidators
    {

        public bool isValidNumber(int number)
        {
            bool isNumeric = false;
            string temp = string.Empty;


            try
            {
            if (!String.IsNullOrEmpty(number.ToString()))
            {
                temp = number.ToString();
            }
           

               isNumeric = Regex.IsMatch(temp, @"(\+|-)?\d+");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Message = {0}", ex.Message);
                Console.WriteLine("StackTrace = {0}", ex.StackTrace);
            }

             return isNumeric;
         
        }


        public bool isValidOpr(string oper)
        {
            bool isOpr = false;
            if (oper != null)
            {
                isOpr = Regex.IsMatch(oper, @"[+\-\\/\*]");
            }
            else if (isOpr)
            {
                return isOpr;
            }
            else
            {
                throw new System.ArgumentException("Your input is not an operator");
            }
            Console.WriteLine("Operator ={0}", isOpr);
            return isOpr;
        }

    }
}
