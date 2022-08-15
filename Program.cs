using System;

namespace MultiFiles
{
    delegate void myDelegate(string myStr, string myStr1);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1-ое число:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите 1-ое число:");
            string str2 = Console.ReadLine();
            Console.WriteLine("Какое действие произвести (+ - сложить, - - вычесть," +
                "* - умножить, / - разделить):");
            string choice = Console.ReadLine();
            myDelegate calc = Class1.Plus;
            if (choice == "+")
            {
                calc(str1, str2);
            }
            else
            {
                if (choice == "-")
                {
                    calc = Class1.Minus;
                    calc(str1, str2);
                }
                else
                {
                    if (choice == "*")
                    {
                        calc = Class1.Multiply;
                        calc(str1, str2);
                    }
                    else
                    {
                        if (choice == "/")
                        {
                            calc = Class1.Divide;
                            calc(str1, str2);
                        }
                    }
                }
            }
        }
    }
}
