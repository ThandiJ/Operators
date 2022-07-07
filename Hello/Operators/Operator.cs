using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Operators
{
     class Operator
    {
        private int num1, num2;
        public Operator(string num1, string num2)
        {
            this.num1 = Convert.ToInt32(num1);
            this.num2 = Convert.ToInt32(num2);

        }

        int Number1 => num1;
        int Number2 => num2;
    }
}
