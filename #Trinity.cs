using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[,] g = new int[5, 5];
            int[] SL = new int[5];
            int[] SC = new int[5];
            int temp = 0;
            int temp1 = 0;

            for (int i = 0; i < 5; i++)
            { 
            
               for (int j = 0; i < 5; j++)
                {

                    g[i, j] = r.Next(0, 50);

                }

            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; i < 5; j++)
                {

                    temp += g[i, j];
                    SL[i] = temp;
                    temp = 0;

                }
            }
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {

                    temp += g[j, i];
                    SC[j] = temp1;
                    temp1 = 0;

                }
            }
        }
    }
}
