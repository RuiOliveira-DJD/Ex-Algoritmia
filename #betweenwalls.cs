using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betweenwalls
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int rn1 = r.Next(1, 101);
            int rn2 = r.Next(1, 101);


            if(rn1 > rn2) { for (int i = rn2; i <= rn1; i++) {
                    Console.WriteLine(i); } }

            if (rn2 > rn1)
            {
                for (int i = rn1; i <= rn2; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
