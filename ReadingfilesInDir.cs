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
            string folderPath = @"D:\AI"; 

            
            if (Directory.Exists(folderPath))
            {
                
                string[] fileNames = Directory.GetFiles(folderPath);

                
                foreach (string fileName in fileNames)
                {
                    Console.WriteLine(fileName);
                }
            }
            else
            {
                Console.WriteLine("Folder not found.");
            }

            Console.ReadLine(); 
        }

    }
    }
    

