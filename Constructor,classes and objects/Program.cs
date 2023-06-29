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
            Books book1 = new Books("Harry potter", "Horror " ,300);
            Student stu1 = new Student("jim", "business", 3.8);
            Student stu2 = new Student("pam", "business", 2.5);


            Console.WriteLine(stu1.Hashonors());
            Console.WriteLine(stu2.Hashonors());

            Console.ReadLine();
        }


    }
}
