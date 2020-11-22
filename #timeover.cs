using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timeover
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 99; i >= 0; i--)
            {
                Console.WriteLine(i);
                if (i == 0) Console.WriteLine("Time Over");
            }
        }
    }
}
