
using Hello;
using Hello.DataTypes;
using Hello.Operators;
/*
Console.WriteLine("Enter the first number:");
string number1 = Console.ReadLine();
Console.ReadKey();
Console.WriteLine("Enter the second number:");
string number2 = Console.ReadLine();
Console.ReadKey();
Console.WriteLine(Arithmetic.GetArithmetic(number1,number2));
Console.ReadKey();
Console.WriteLine(Arithmetic.GetIncrement());
Console.ReadKey();
Console.WriteLine(Arithmetic.GetDecrement());
Console.ReadKey();

Console.WriteLine(Assignment.GetAssignment());
Console.ReadKey();

Console.WriteLine(Relational.GetRelational());
Console.ReadKey();

Console.WriteLine(Logical.GetLogical());
Console.ReadKey();

Console.WriteLine(Bitwise.GetBitwise());
Console.ReadKey();

Console.WriteLine(Miscellaneous.GetMisc());
*/
namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine(@"Choose an option
                        1) Arithmetic Operators
                        2) Relational Operator
                        3) Logical Operator
                        4) Assignment Operator
                        5) Bitwise
                        6) Miscellaneous
                        7) Exit");
            Console.Write("\r\nSelect an option: ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Enter the first number:");
                    Console.ForegroundColor = ConsoleColor.Red;
                    string number1 = Console.ReadLine();
                    Console.ReadKey();
                    Console.WriteLine("Enter the second number:");
                    string number2 = Console.ReadLine();
                    Console.ReadKey();
                    Console.WriteLine(Arithmetic.GetArithmetic(number1, number2));
                    Console.ReadKey();
                    Console.WriteLine(Arithmetic.GetIncrement(number1, number2));
                    Console.ReadKey();
                    Console.WriteLine(Arithmetic.GetDecrement(number1, number2));
                    Console.ReadKey();
                    return true;

                case "2":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Enter the first number:");
                    string num1 = Console.ReadLine();
                    Console.ReadKey();
                    Console.WriteLine("Enter the second number:");
                    string num2 = Console.ReadLine();
                    Console.WriteLine(Relational.GetRelational(num1,num2));
                    Console.ReadKey();
                    return true;

                case "3":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Enter a value:");
                    string count = Console.ReadLine();
                    Console.WriteLine(Logical.GetLogical(count));
                    Console.ReadKey();
                    return true;

                case "4":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Enter the first value:");
                    string num_x = Console.ReadLine();
                    Console.WriteLine("Enter the second value: ");
                    string num_y = Console.ReadLine();
                    Console.WriteLine(Assignment.GetAssignment(num_x, num_y));
                    Console.ReadKey();
                    return true;

                case "5":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Enter the first value:");
                    string num_a = Console.ReadLine();
                    Console.WriteLine("Enter the second value: ");
                    string num_b = Console.ReadLine();
                    Console.WriteLine(Bitwise.GetBitwise(num_a, num_b));
                    Console.ReadKey();
                    return true;

                case "6":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(Miscellaneous.GetMisc());
                    Console.ReadKey();
                    return true;

                case "7":
                    Console.ForegroundColor = ConsoleColor.Red;
                    return false;

                default: return true;
            }
        }
    }
}

