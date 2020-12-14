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
            int a = 0;
            bool card = true;

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
                 while(card) {                                        //////A outra maneira tb dava mas assim fica diferente
                   
                    if (baralho1[i] == baralho2[a]) { contador++; }   //////A TERCEIRA É DE VEZ, culpo estar cansado 
                    a++;
                    if(a >= 9) card = false;
                }
                card = true;
                a = 0;
            }


            Console.WriteLine(contador + "  cards in common");

        }
    }
}
