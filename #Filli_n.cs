using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filli_n
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valoresA = new int[10]; //////////////////////////a)

            for (int i = 0; i < 10; i++)
            {

                valoresA[i] = i + 1;
            }

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(valoresA[i]);
            }




            int[] valoresB = new int[10]; //////////////////////////b)           

            for (int i = 0; i < 10; i++)
            {
                if (i < 5)
                {
                    valoresB[i] = i + 1;
                }
                if (i >= 5)
                    valoresB[i] = (i - 4) * 10;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(valoresB[i]);
            }




            int[] valoresC = new int[11]; //////////////////////////c)

            for (int i = 0; i < 11; i++)
            {
                if (i >= 2)
                {
                    valoresC[i] = i * i;
                }
                else
                {
                    valoresC[i] = i;
                }
            }
           
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(valoresC[i]);
            } 
            
            
            int[] valoresD = new int[10]; //////////////////////////d)

            valoresD[0] = 0;
            valoresD[1] = 1;

            for (int i = 2; i < valoresD.Length; i++)
            {
                valoresD[i] = valoresD[i - 1] + valoresD[i-2];
            }

            for (int i = 0; i < valoresD.Length; i++)
            {
                Console.WriteLine(valoresD[i]);
            }

            }
        }
    }


