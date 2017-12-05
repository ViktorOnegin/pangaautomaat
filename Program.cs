using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. KontoLoomine");
                Console.WriteLine("2. Pangaautomaat");
                Console.WriteLine("Sisestage oma valik");
                int valik = int.Parse(Console.ReadLine());

                switch (valik)
                {
                    case 1:
                        KontoLoomine konto = new KontoLoomine();
                        konto.LooKonto();
                        break;

                    case 2:
                        Pangaautomaat pangaautomaat = new Pangaautomaat();
                        pangaautomaat.Sisselogimine();
                        break;
                }
            }
        }
    }
}
