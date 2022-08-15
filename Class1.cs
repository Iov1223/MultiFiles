using System;
using System.Collections.Generic;
using System.Text;

namespace MultiFiles
{
    class Class1
    {
        static public void Plus(string num1, string num2)
        {
            double n1 = Convert.ToInt32(num1);
            double n2 = Convert.ToInt32(num2);
            double res = n1 + n2;
            Console.WriteLine("{0} + {1} = {2}", n1, n2, res);
        }
        static public void Minus(string num1, string num2)
        {
            double n1 = Convert.ToInt32(num1);
            double n2 = Convert.ToInt32(num2);
            double res = n1 - n2;
            Console.WriteLine("{0} - {1} = {2}", n1, n2, res);
        }
        static public void Multiply(string num1, string num2)
        {
            double n1 = Convert.ToInt32(num1);
            double n2 = Convert.ToInt32(num2);
            double res = n1 * n2;
            Console.WriteLine("{0} * {1} = {2}", n1, n2, res);
        }
        static public void Divide(string num1, string num2)
        {
            double n1 = Convert.ToInt32(num1);
            double n2 = Convert.ToInt32(num2);
            if (n2 == 0)
            {
                Console.WriteLine("На нодь делить нельзя");
            }
            else
            {
                double res = n1 / n2;
                Console.WriteLine("{0} / {1} = {2}", n1, n2, res);
            }
        }

    }
}
