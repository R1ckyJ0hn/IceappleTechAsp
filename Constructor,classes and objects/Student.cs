using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public string name;
        public string sub;
        public double gpa;
        

        public Student(string aname, string asub, double agpa)
        {
            name = aname;
            sub = asub;
            gpa = agpa;
        }

        public bool Hashonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
    }

   
}
