using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keeprandomizing
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();

            int n = r.Next(1, 20);

            for (int i = 0; i < n; i++)
            {

                int posX = r.Next(0, 500);
                int posY = r.Next(0, 500);

                Console.WriteLine("Player is at  x->" + posX + " /  y->" + posY);

            }



            }
    }
}
