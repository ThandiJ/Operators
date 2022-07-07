using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class ArithOperator 
    {
        internal string GetDecrement()
        {
            int number1 = 6, number2 = 10;
            int result1, result2;
            StringBuilder sb = new("\tUnary Operator\n*************Decrement************\n");
            result1 = number1--;
            sb.AppendLine($"Post Decrement: number is {number1} and result is {result1}");

            result2 = --number2;
            sb.AppendLine($"Pre Decrement: number is {number2} and result is {result2}");

            return sb.ToString();
        }
    }
}
