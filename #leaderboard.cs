using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leaderboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int p1 = r.Next(1, 100);
            int p2 = r.Next(1, 100);
            int p3 = r.Next(1, 100);



            int maior1 = p1;
            int maior2 = p2;
            int maior3 = p3;

            if(p2 > maior1)
            {
                maior2 = maior1;
                maior1 = p2;
            } 

            if(p3 > maior1)
            {
                maior3 = maior2;
                maior2 = maior1;
                maior1 = p3;
            }
           
            else
            {
                if(p3 > maior2)
                {
                    maior3 = maior2;
                    maior2 = p3;
                }
            }
            

        }
    }
}
