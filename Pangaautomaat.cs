using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Pangaautomaat : KontoLoomine
    {
        public void Sisselogimine()
        {
            Console.WriteLine("Sisestage Kontonumber");
            int kontonumber = int.Parse(Console.ReadLine());

            if (kontonumber == Kontonumber)
            {
                Console.WriteLine("Sisestage Pin");
                int pin = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Proovige uuesti");
            }
        }
    }
}
