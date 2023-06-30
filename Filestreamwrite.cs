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
            string textfilepath = @"D:\AI\testfile.txt";

            FileStream fd = File.Open(textfilepath ,FileMode.Create);

            string x = "This is a random string named x";
            byte[] rsArray = Encoding.Default.GetBytes(x);

            fd.Write(rsArray, 0, rsArray.Length);

            fd.Position = 0;

            byte[] readarray = new byte[rsArray.Length];

            for (int i = 0; i < rsArray.Length; i++)
            {
                readarray[i] = (byte)fd.ReadByte();
            }


            Console.WriteLine(Encoding.Default.GetString(readarray));

            fd.Close();


            Console.ReadLine();


        }

    }
    }
    

