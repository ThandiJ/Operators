using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Operators
{
    internal class Relational
    {
        internal static string GetRelational(string number1,string number2)
        {
            int num1 = Convert.ToInt32(number1), num2 = Convert.ToInt32(number2);
            StringBuilder sb = new("**********Relational Operators*************\n");
            bool result;

            result = num1 == num2;
            sb.AppendLine($"Equal to operator(num1 == num2): {result}");

            result = num1 != num2;
            sb.AppendLine($"Not equal to operator(num1 != num2): {result}");

            result = num1 > num2;
            sb.AppendLine($"Greater than operator(num1 > num2): {result}");

            result = num1 < num2;
            sb.AppendLine($"Less than operator (a < b): {result}");

            result = num1 >= num2;
            sb.AppendLine($"Greater than or Equal to operator (num1 < num2): {result}");

            result = num1 <= num2;
            sb.AppendLine($"Less than or Equal to operator(num1 <= num2): {result}");

            return sb.ToString();
        }
    }
}
