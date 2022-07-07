using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Operators
{
    internal class Miscellaneous
    {
        internal static string GetMisc()
        {
            StringBuilder sb = new StringBuilder("************Misc Operators************");
            int day = 12;
            string result;

            result = sizeof(int).ToString();
            sb.AppendLine($"sizeof int: {result}");

            result = typeof(int).ToString();
            sb.AppendLine($"typeof int: {result}");

            result = day > 7 ? "Correct" : "Try again";
            sb.AppendLine($"Ternary/conditional(day > 7) :{result}");

            if(day !=0)
            { result =  (day is 0).ToString(); }
            sb.AppendLine($"Ternary/conditional(day is <0) :{result}");

            return sb.ToString();
        }
    }
}
