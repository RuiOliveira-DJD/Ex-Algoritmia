using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] deck1 = new int[52];
            int[] deck2 = new int[52];
            int[] playerOne = new int[10];
            int[] playerTwo = new int[10];
            int contador = 0;
            int a = 0;
            bool card = true;

            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                bool valid = false;
                while (!valid)
                {
                    int index = r.Next(deck1.Length);
                    if (deck1[index] != -1)
                    {
                        deck1[index] = -1;
                        playerOne[i] = index;
                        break;
                    }

                }

                while (!valid)
                {
                    int index2 = r.Next(deck2.Length);
                    if (deck2[index2] != -1)
                    {
                        deck2[index2] = -1;
                        playerTwo[i] = index2;
                        break;
                    }

                }


            }

            for (int i = 0; i < 10; i++)
            {
                while (card)
                {

                    if (playerOne[i] == playerTwo[a]) { contador++; }
                    a++;
                    if (a >= 9) card = false;
                }
                card = true;
                a = 0;
            }


            Console.WriteLine(contador + "  cards in common");


        }
    }
}
