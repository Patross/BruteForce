using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BruteForce
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "77";
            
            ///
            ///Create and combine arrays into one big array
            ///
            char[] alphaUppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] alphaLowercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();
            char[] numbers = "0123456789".ToCharArray();
            char[] dictionary = alphaLowercase.Concat(alphaUppercase).Concat(numbers).ToArray();

            Console.WriteLine(dictionary.Length);

            int guessLength = 1;
            char[] guess = null;
            do
            {
                foreach (char dicItem in dictionary)
                {
                    guess[1]
                }

            } while (guess != password);
                //Console.WriteLine(guess);
        }
    }
}
