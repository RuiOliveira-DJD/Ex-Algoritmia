using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oof
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            bool Lider = false;

            int[] Level = new int[20];

            for (int i = 0; i < Level.Length; i++)
            {

                int Rlevels = r.Next(0, 121);

                Level[i] = Rlevels;

                for (int a = i + 1; a < Level.Length; a++)
                {

                    if (Level[i] < Level[a])
                    {
                        Lider = false;
                        break;
                    }
                }
                if (Lider) Console.WriteLine(Level[i] + " e lider");
                else Lider = true;
            }
        }
    }
}

