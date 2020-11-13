using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lostinthemap
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int x = r.Next(0, 500);
            int y = r.Next(0, 500);

            if (x > 250 && y > 250) Console.WriteLine("The character is on the Bottom-Right Side of the map");
            else { if (x < 250 && y < 250) Console.WriteLine("The character is on the Top-Left side of the map"); }
            if (x > 250 && y < 250) Console.WriteLine("The character is on the Top-Right side of the map"); 
            else { if (x < 250 && y > 250) Console.WriteLine("The character is on the Bottom-Left side of the map"); }
        }
    }
}
