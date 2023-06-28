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
            int[,] numbergrid =
              {
                {1,2 },{3,4},{5,6}
            };
            for (int i = 0; i<=2;i++) {
                for (int j = 0; j <2; j++)
                {
                    Console.WriteLine(numbergrid[i, j]);
                }

            
            };
            Console.ReadLine();

        }


    }
}
