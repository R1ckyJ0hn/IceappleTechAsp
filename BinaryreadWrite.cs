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
            string textFilePath4 = @"D:\AI\testfile5.dat";

            
            FileInfo datFile = new FileInfo(textFilePath4);

            
            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

            
            string randText = "Random Text";
            int myAge = 42;
            double height = 6.25;

            
            bw.Write(randText);
            bw.Write(myAge);
            bw.Write(height);

            bw.Close();

            
            BinaryReader br = new BinaryReader(datFile.OpenRead());

            
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());

            br.Close();

            Console.ReadLine();

            Console.ReadLine(); 
        }

    }
    }
    

