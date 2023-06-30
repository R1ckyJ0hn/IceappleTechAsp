using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool intinp = Comparison(1, 2);
            Console.WriteLine(intinp);

            bool strinp = Comparison("Ricky", "Ricky");
            Console.WriteLine(strinp);

            Console.ReadLine();

        }

        public static bool Comparison<typee>(typee value1,typee value2)
        {
            return value1.Equals(value2);
            
        }


    }
    class Genericexample<typ>
    {
        public static bool Comparison(typ value1, typ value2)
        {
            return value1.Equals(value2);

        }

    }
}
