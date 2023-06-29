using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Books
    {
        public string Name;
        public string Genre;
        public int price;

        public Books(string aname , string AGenre , int aprice)
        {
            Name = aname;
            Genre = AGenre;
            price = aprice;

        }
        public Books()
        {

        }
    }
}
