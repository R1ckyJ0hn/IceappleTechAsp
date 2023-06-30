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
            string textFilePath3 = @"D:\AI\testfile2.txt";

            
            StreamWriter sw = File.CreateText(textFilePath3);

            
            sw.Write("This is a random ");

            
            sw.WriteLine("sentence.");

           
            sw.WriteLine("This is another sentence.");

           
            sw.Close();

            
            StreamReader sr = File.OpenText(textFilePath3);

            Console.WriteLine("Peek : {0}",
                Convert.ToChar(sr.Peek()));

            
            Console.WriteLine("1st String : {0}",
                sr.ReadLine());

            
            Console.WriteLine("Everything : {0}",
                sr.ReadToEnd());

            sr.Close();


        }

    }
    }
    

