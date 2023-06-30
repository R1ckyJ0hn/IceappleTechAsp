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
            ArrayList alist = new ArrayList();
            alist.Add("Hello");
            alist.Add(42);
            alist.Add(DateTime.Now);

            foreach (object item in alist)
            {
                Console.WriteLine(item);
            }

            List<string> list = new List<string>();
            list.Add("Hello");
            list.Add("World");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
    
}
