using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alialawayswins
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();         
           
            float Health1 = 100;
            float Health2 = 100;
            bool CheckHealth = true;
            bool Block1 = true;
            bool Block2 = true;
            int Turns = 0;

            while (CheckHealth)
            {
                Turns++;
                int DecisionP1 = r.Next(1, 3);
                int DecisionP2 = r.Next(1, 3);
                int Attack1p1 = r.Next(1, 11);
                int Attack2p1 = r.Next(1, 20);
                int Attack1p2 = r.Next(1, 11);
                int Attack2p2 = r.Next(1, 20);
                int useBlock = r.Next(1, 3);

                if (DecisionP2 == 3) { if (useBlock == 1) Block1 = false; }
                if (DecisionP1 == 3) { if (useBlock == 1) Block2 = false; }

                if (DecisionP1 == 1) { if (Block2 == true) Health2 -= Attack1p1; }
                else { if (DecisionP1 == 2) { if (Block2 == true) Health2 -= Attack2p1; } }


                if (DecisionP2 == 1) { if (Block1 == true) Health2 -= Attack1p2; }
                else { if (DecisionP2 == 2) { if (Block1 == true) Health2 -= Attack2p2; } }


                if (Health1 <= 0)
                {
                    CheckHealth = false;
                    Console.WriteLine("Player 1 Knocked out!");

                }

                if (Health2 <= 0)
                {
                    CheckHealth = false;
                    Console.WriteLine("Player 2 Knocked out!");
                }
            }










            }







        }
    }
}
