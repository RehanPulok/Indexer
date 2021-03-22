using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Indexer
    {

        private string[] cities = new string[5];


        public string this[int index]
        {
            get
            {

                return cities[index];
            }

            set
            {
                cities[index] = value;
            }
        }
    }
}

   