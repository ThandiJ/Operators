using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Operators
{
    internal class Arithmetic
    {
        internal static string GetArithmetic(string x1,string x2)
        {
            int num1 =Convert.ToInt32(x1);
            int num2 =Convert.ToInt32(x2);
            float result;
            StringBuilder sb = new("\tBinary Operators\n************Arithmetic Operators************\n");

            result = (float)num1 / num2;
            sb.AppendLine($"Division Operator: {result}");

            result = num1 * num2;
            sb.AppendLine($"Multiplication Operator: {result}");

            result = num1 + num2;
            sb.AppendLine($"Addition Operator: {result}");

            result = num1 - num2;
            sb.AppendLine($"Subtraction Operator: {result}");

            result = num1 % num2;
            sb.AppendLine($"Modulo Operator: {result}");

            return sb.ToString();
        }

         internal static string GetIncrement(string num1,string num2)
        {
            int number1 = Convert.ToInt32(num1);
            int number2 = Convert.ToInt32(num2);
            int result1,result2;
            StringBuilder sb = new("\tUnary Operator\n*************Increment************\n");
            result1 = number1++;
            sb.AppendLine($"Post Increment: number is {number1} and result is {result1}");

            result2 = ++number2;
            sb.AppendLine($"Pre Increment: number is {number2} and result is {result2}");

             return sb.ToString();
         }

        internal static string GetDecrement(string num1,string num2)
        {
            int number1 = Convert.ToInt32(num1);
            int number2 = Convert.ToInt32(num2);
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
