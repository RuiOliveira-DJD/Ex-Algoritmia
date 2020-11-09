using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace secretnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int secretnumber = r.Next(0, 101);
            bool GuessNumber = true;

            while (GuessNumber)
            {

                Console.WriteLine("What is the secret number?");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == secretnumber)
                {
                    GuessNumber = false;
                    Console.WriteLine("You found the secret number!");
                }
                else if (guess < secretnumber)
                {
                    Console.WriteLine("The secret number is greater than your guess.");
                }
                else
                {
                    Console.WriteLine("The secret number is smaller than your guess.");
                }

            }

        }
    }
}
