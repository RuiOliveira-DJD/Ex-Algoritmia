using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fightorflight
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int px1 = r.Next(0, 500);
            int px2 = r.Next(0, 500);
            int py1 = r.Next(0, 500);
            int py2 = r.Next(0, 500);

            float distancia = ((px2 - px1) * (px2 - px1) + (py2 - py1) * (py2 - py1)) * ((px2 - px1) * (px2 - px1) + (py2 - py1) * (py2 - py1));

            //tentei nao usar math.sqrt e criar extra variaveis 

            if(distancia < 20)
            {
                Console.WriteLine("Player 2 has left the map");
            }

        }
    }
}
