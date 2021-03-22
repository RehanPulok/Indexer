using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Indexer index = new Indexer();
            index[0] = "DHAKA";
            index[1] ="CHITTAGONG";
            index[2] ="BARISHAL";
            index[3] ="RAJSHAHI";
            index[4] ="KHULNA";
            Console.WriteLine("Write a name of the city: ");
            string city = Console.ReadLine().ToUpper();
            int found = 0;
            for (int i = 0; i < 5; i++)
            {
                if (city == index[i])
                {
                    Console.WriteLine("City found");
                    found = found + 1;
                    break;
                }
                
            }
            if (found==0)
            {
                Console.WriteLine("City not found");
            }
            
            Console.ReadLine();
            

        }
    }
}
