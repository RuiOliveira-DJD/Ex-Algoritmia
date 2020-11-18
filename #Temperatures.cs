using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            float[] temps = new float[10];
            float sum = 0;
            
           
            for(int i = 0; i < temps.Length; i++)
            {
                temps[i] = r.Next(-29, 51);
                sum += temps[i];

                if(temps[i] < 0)
                {
                    Console.WriteLine("Negative temperature "+ temps[i] + "Celsius");
                }
            }
            float average = sum / 10;

            Console.WriteLine("Average temperature is " + average + "Celsius");
        }
    }
}
