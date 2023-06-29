using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Films
    {
        public string name;
        public string director;
        private string rating;

        public Films(string aname, string adirector, string arating)
        {
            name = aname;
            director = adirector;
            Rating = arating;
        }

        public string Rating
        {
            get { return rating; }

            set
            {
                
                if(value == "G" || value == "PG" || value == "PG-13" || value == "NR" ) {
                    rating = value;
                
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
