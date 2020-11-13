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

            float SimHealthp1 = r.Next(100, 200);
            float SimHealthp2 = r.Next(100, 200);
            float MainHealthp1 = SimHealthp1;   //Para alterar a health de simulação apenas visto que é um programa para dar Predict e não executar a ação
            float MainHealthp2 = SimHealthp2; 
            float ATp1 = r.Next(10, 50);
            float ATp2 = r.Next(10, 50);
            bool Alive = true;

            while (Alive)
            {
                 SimHealthp1 -= ATp2;
                 SimHealthp2 -= ATp1;

                if (SimHealthp1 < 0 && SimHealthp2 < 0)
                {
                    Console.WriteLine("They both die");
                    break;
                }

                if (SimHealthp1 < 0)
                {
                    Console.WriteLine("Player 2 will win the fight");
                    Alive = false;
                }
                else
                {
                    if (SimHealthp2 < 0)
                    {
                        Console.WriteLine("Player 1 will win the fight");
                        Alive = false;
                    }
                }

                     
            }
        }

    }
}


