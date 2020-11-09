using System;
using System.Threading.Tasks.Dataflow;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int px1 = r.Next(0, 501);
            int py1 = r.Next(0, 501);
            int px2 = r.Next(0, 501);
            int py2 = r.Next(0, 501);
            int px3 = r.Next(0, 501);
            int py3 = r.Next(0, 501);
            float dist1 = (float)Math.Sqrt((px1 - px2) * (py1 - py2));
            float dist2 = (float)Math.Sqrt((px2 - px3) * (py2 - py3));
            float dist3 = (float)Math.Sqrt((px3 - px1) * (py3 - py1));

            if ((dist2 - dist1) > (dist3 - dist2) && (dist3 - dist2) > (dist3 - dist1)) { Console.WriteLine("player3 and player1 are the closest to each other"); }
            if ((dist3 - dist1) > (dist2 - dist1) && (dist2 - dist1) < (dist3 - dist2)) { Console.WriteLine("player2 and player1 are the closest to each other"); }
            if ((dist3 - dist1) > (dist3 - dist2) && (dist3 - dist2) < (dist2 - dist1)) { Console.WriteLine("player3 and player2 are the closest to each other"); }

            //tentei usar o minimo de var que achei possivel


        }
    }
}