using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Child:Parent
    {
        public override void meth4()
        {
            Console.WriteLine("This is the overridden meth");
        }
    }
}
