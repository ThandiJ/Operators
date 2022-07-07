using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Operators
{
    internal class Assignment
    {
        internal static string GetAssignment(string x,string y)
        {
            StringBuilder sb = new("************Assignment Operators************\n");
            int number1 =Convert.ToInt32(x); float number2 = Convert.ToInt32(y);
            sb.AppendLine($"Assignment operator(=) : number1 is {number1} and number2 is {number2}");

            number1 += 10;
            sb.AppendLine($"Add assignment operator(+=) : {number1}");

            number1 -= 10;
            sb.AppendLine($"Subtract assignment operator(-=) : {number1}");

            number1 /= 5;
            sb.AppendLine($"Division assignment operator(/=): {number1}");

            number2 *= 2;
            sb.AppendLine($"Multiply assignment operator(*=) : {number2}");

            number2 %= 5;
            sb.AppendLine($"Modulo assignment operator (%=) : {number2}");
            return sb.ToString();
        }
    }
}
