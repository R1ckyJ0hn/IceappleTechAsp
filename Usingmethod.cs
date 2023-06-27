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
            int res = cube(5);
            
            
            Console.WriteLine(res);
            Console.ReadLine();
        }
        static int  cube(int num)
        {
            int cubeNo = num * num * num;
            return cubeNo;
        }


    }
}
