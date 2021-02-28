using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior_que__menor_que
{
    class Maior 
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = 20;
            int c = 2;


            if (a < b)
            {
                Console.WriteLine("É verdade!");
            }
            else if (a > c)
            {
                Console.WriteLine("!Executou Elseif");
            }
            
            else
            {
                Console.WriteLine("É mentira!");
            }
            
            Console.ReadLine();
        }
    }
}
