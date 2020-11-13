using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roll
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int rollp1 = r.Next(1, 6);
            int rollp2 = r.Next(1, 6);

            if (rollp1 > rollp2) Console.WriteLine("Player 1 rolled higher and got the item!");
            else { Console.WriteLine("Player 2 rolled higher and got the item!"); }



        }
    }
}
