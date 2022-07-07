using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.FlowControl
{
    internal class floatControl
    {
        //int score = 10;
        internal static string GetGradeFromScore(int score)
        {
            if (score >= 90)
            { return "Distinction"; }
            else if (score >= 80)
            { return "Merit"; }
            else if (score >= 75)
            { return "Pass"; }
            else
            { return "Fail"; }

        }
        internal static string GetGradeFromScoreDynamic(int score)
        {
            string grade = "";
            if (score >= 90)
            { grade = "Distinction"; }
            else if (score >= 80)
            { grade = "Merit"; }
            else if (score >= 75)
            { grade = "Pass"; }
            else
            { grade = "Fail"; }

            return grade;
        }

        internal static string GetGradeFromScoreDynamicSwitch(int score)
        {
            string grade = "";
            switch (score)
            {
                case >= 90:
                    grade = "Distinction";
                    break;
                case >= 80:
                    grade = "Merit";
                    break;
                case >= 75:
                    grade = "Pass";
                    break;
                default:
                    grade = "Fail";
                    break;
            }

            return grade;
        }

        internal static string GetGradeFromScoreDynamicSwitchExpression(int score)
        {
            var grade = score switch
            {
                >= 90 => "Distinction",
                >= 80 => "Merit",
                >= 75 => "Pass",
                _ => "Fail"
            };

            return grade;
        }

        internal static string GetResultIfEslse(int a, int b)
        {
            string result = "";
            if (a > b)
            {
                result = Convert.ToString(a);
            }
            else
            {
                result = Convert.ToString(b);
            }
            return result;
        }

        internal static string GetResultTernary(int a, int b)
        {
            string result = a > b ? Convert.ToString(a) :
                Convert.ToString(b);


            return result;
        }

        internal static string WhileLoop()
        {
            int num = 10;
            string returnValue = "";
            while (num < 20)
            {
                returnValue = num.ToString();
                num++;

            }
            return "current value is: " + returnValue;
        }

        internal static string WhileLoop1(int num)
        {
            StringBuilder sb = new StringBuilder();
            while (num < 20)
            {
                sb.Append("current value is: " + num.ToString() + "\n");
                num++;

            }
            return sb.ToString();
        }
        internal static string DoWhileLoop(int num)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("Start while loop\n");
            do
            {
                sb.Append($"current value is: {num}\n");
                num++;

            } while (num < 20);
            return sb.ToString();
        }
        internal static string GetForLoop()
        {
            StringBuilder sb = new("Start for loop\n");
            for (int i = 10; i < 20; i++)
            {
                sb.Append($"current value is: {i}\n");
            }
            return sb.ToString();
        }
        internal static string GetForEach()
        {
            StringBuilder sb = new("start Foreach\n");
            int[] array1 = new int[3];
            array1[0] = 10;
            array1[1] = 20;
            array1[2] = 30;

            foreach (int num in array1)
            {
                sb.Append(num.ToString() + "\n");
            }

            return sb.ToString();
        }
        internal static string GetForArray(int[] numbers)
        {
            StringBuilder sb = new("start Foreach\n");

            foreach (int num in numbers)
            {
                sb.Append(num.ToString());
            }
            return sb.ToString();
        }

        internal static string GetForArrayParams(params int[] numbers)
        {
            StringBuilder sb = new("start Array Params\n");

            foreach (int num in numbers)
            {
                sb.Append(num.ToString() + "\n");
            }
            return sb.ToString();
        }
        internal static string FlowControlReverse(int number)
        {
            StringBuilder sb = new("Start reverse\n");
            for (int i = number; i > 0; i--)
            {
                sb.Append(i.ToString() + "\n");
            }
            return sb.ToString();
        }
        internal static string FlowControlFizzBuzz()
        {
            StringBuilder sb = new("Flow Control\n");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    sb.Append("FIZZ BUZZ\n");
                }
                else if (i % 3 == 0)
                {
                    sb.Append("FIZZ\n");
                }
                else if (i % 5 == 0)
                {
                    sb.Append("BUZZ\n");
                }
                else
                {
                    sb.Append(i.ToString() + "\n");
                }

            }
            return sb.ToString();
        }
        internal static int GetSumFromArray(params int[] numbers)
        {
            Debug.Assert(numbers.Length > 0, "The numbers array is empty");
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

    }
}
