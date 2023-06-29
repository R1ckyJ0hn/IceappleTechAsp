using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Parent
    {
        public void meth1()
        {
            Console.WriteLine("This is meth 1");
        }
        public void meth2()
        {
            Console.WriteLine("This is meth 2");
        }
        public void meth3()
        {
            Console.WriteLine("This is meth 3");
        }

        public virtual void meth4()
        {
            Console.WriteLine("This is meth 4");
        }
    }
}
