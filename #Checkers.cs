using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = "Branco";
            String b = "Preto";
            String aa = "Peca Branca";
            String bb = "Peca preta";

            Boolean check = true;

            String[,] checkers = new String[8, 8];
            String[,] pecas = new String[8, 8];

            for (int i = 0; i < 8; i++)
            {
                if (check == true)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (j % 2 == 0)
                        {
                            checkers[i, j] = a;
                            if (i >= 5)
                            {
                                pecas[i, j] = bb;
                            }

                            check = false;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (j % 2 == 0)
                        {
                            checkers[i, j] = b;
                            if (i <= 2)
                            {
                                pecas[i, j] = aa;
                            }
                            check = true;
                        }
                    }
                }
            }
        }
    }
}
