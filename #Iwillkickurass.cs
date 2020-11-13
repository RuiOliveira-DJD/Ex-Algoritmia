using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iwillkickurass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            float Healthp1 = r.Next(100, 200);
            float Healthp2 = r.Next(100, 200);
            float ATp1 = r.Next(10, 50);
            float ATp2 = r.Next(10, 50);
            bool Alive = true;

            while (Alive)
            {
                 Healthp1 -= ATp2;
                 Healthp2 -= ATp1;

                if (Healthp1 < 0 && Healthp2 < 0)
                {
                    Console.WriteLine("They both die");
                    break;
                }

                if (Healthp1 < 0)
                {
                    Console.WriteLine("Player 2 will win the fight");
                    Alive = false;
                }
                else
                {
                    if (Healthp2 < 0)
                    {
                        Console.WriteLine("Player 1 will win the fight");
                        Alive = false;
                    }
                }

                     
            }
        }

    }
}


