using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine(Add(2,3));
            Console.WriteLine(Sub(2,3));
            Console.WriteLine(Mult(2,3));
            Console.WriteLine(Div(2,3));
            Console.ReadLine();

        }

        static int Add(int num1, int num2)
        {
            int result = num1 + num2;

            return result;
        }
        static int Sub(int num1 , int num2)
        {
            int result = num1 - num2;
            return result;
        }
        static int Mult(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
        static double Div(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }


    }
}
