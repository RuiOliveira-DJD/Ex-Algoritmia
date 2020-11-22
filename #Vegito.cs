using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegito
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int attack1 = r.Next(1, 50);
            int attack2 = r.Next(1, 50);
            int defense1 = r.Next(1, 50);
            int defense2 = r.Next(1, 50);
            int intellect1 = r.Next(1, 50);
            int intellect2 = r.Next(1, 50);

            int fusionAT = (attack1 + attack2) / 2;
            int fusionDEF = (defense1 + defense2) / 2;
            int fusionINT = (intellect1 + intellect2) / 2;

            Console.WriteLine("Fusion Attack = " + fusionAT + "  Fusion Defense = " + fusionDEF + "  Fusion Intellect = " + fusionINT);


        }
    }
}
