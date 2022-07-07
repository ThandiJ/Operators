using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Operators
{
    internal class Bitwise
    {
        internal static string GetBitwise(string num1, string num2)
        {
            StringBuilder sb = new("************Bitwise Operators************\n");
            int x = Convert.ToInt32(num1), y = Convert.ToInt32(num2),result;

            result = x & y;
            sb.AppendLine($"Bitwise AND (x & y) : {result}");

            result = x | y;
            sb.AppendLine($"Bitwise OR (x | y) : {result}");

            result = x ^ y;
            sb.AppendLine($"Bitwise XOR (x ^ y) : {result}");

            result = ~x;
            sb.AppendLine($"Bitwise complement (~x) : {result}");

            result = x << 2;
            sb.AppendLine($"Bitwise left shift (y<<2): {result}");

            result = x >> 2;
            sb.AppendLine($"Bitwise right shift (y>>2): {result}");

            return sb.ToString();
        }
    }
}
