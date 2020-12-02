using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();


            int contador = 0;

            int[] baralho1 = new int[10];
            int[] baralho2 = new int[10];

            for (int i = 0; i < baralho1.Length; i++)
            {
                baralho1[i] = r.Next(0, 53);
            }

            for (int i = 0; i < baralho2.Length; i++)
            {
                baralho2[i] = r.Next(0, 53);
            }

            for (int i = 0; i < 10; i++)
            {
                if (baralho1[i] == baralho2[i]) { contador++; }
            }


            Console.WriteLine(contador + "  cards in common");

        }
    }
}
