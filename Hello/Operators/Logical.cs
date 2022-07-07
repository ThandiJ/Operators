using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Operators
{
    internal class Logical
    {
        internal static string GetLogical(string x )
        {
            StringBuilder sb = new("*************Logical Operators****************\n");
            bool result;
            int count = Convert.ToInt32(x);

            result = (count > 0 && count < 10);
            sb.AppendLine($"AND operator (count > 0 && count < 10): {result}");

            result = (count > 1 || count > 9);
            sb.AppendLine($"OR operator (count > 0 || count < 10): {result}");

            result = !(count> 0 && count<10 );
            sb.AppendLine($"Not operator !(count> 0 && count<10 ): {result}");   
       
            return sb.ToString();
        }
    }
}
