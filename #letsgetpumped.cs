using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letsgetpumped
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            float attack = r.Next(0, 50);

            float powerup = attack / 2;

            float poweredupattack = attack + powerup;

            Console.WriteLine("Normal attack = " + attack);
            Console.WriteLine("Powered UP attack = " + poweredupattack);
        }
    }
}
