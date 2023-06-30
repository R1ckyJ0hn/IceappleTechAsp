using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Collections;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo mydatadir = new DirectoryInfo(@"D:\AI");

            FileInfo[] txtfile = mydatadir.GetFiles("*.txt",SearchOption.AllDirectories);

            Console.WriteLine("Matches :" +txtfile.Length);

            foreach(FileInfo file in txtfile)
            {
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Length);
            }

            Console.ReadLine();
        }

    }
    }
    

