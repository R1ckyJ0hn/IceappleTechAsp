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
            Parent method =new Parent();
            Child childmeth = new Child();
            method.meth1();
            method.meth2();
            method.meth3();
            method.meth4();
            childmeth.meth1();
            childmeth.meth2();
            childmeth.meth3();
            childmeth.meth4();

            Console.ReadLine();
        }


    }
}
