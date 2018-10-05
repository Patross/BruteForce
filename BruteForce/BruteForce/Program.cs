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
            ///
            ///Create and combine arrays into one big array
            ///

             // Array with characters to use in Brute Force Algorithm.
             // You can remove or add more characters in this array.
        private static char[] fCharList =
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
            'u', 'v', 'w', 'x', 'y', 'z','A','B','C','D','E',
            'F','G','H','I','J','K','L','M','N','O','Q','R',
            'S','T','U','V','W','X','Y','Z','1','2','3','4',
            '5','6','7','8','9','0'
        };

        static void Main(string[] args)
        {
            string guess = "";
            string password = "az";
            int guessLength = 1;

            while (guess != password)
            {
                guess = StartBruteForce(guessLength);
                guessLength++;
            }
        }

        /// <summary>
        /// Start Brute Force.
        /// </summary>
        /// <param name="length">Words length.</param>
        public static string StartBruteForce(int length)
        {
            string result;
            StringBuilder sb = new StringBuilder(length);
            char currentChar = fCharList[0];

            for (int i = 1; i <= length; i++)
            {
                sb.Append(currentChar);
            }

            result = ChangeCharacters(0, sb, length);
            return result;
        }

        private static string ChangeCharacters(int pos, StringBuilder sb, int length)
        {
            for (int i = 0; i <= fCharList.Length - 1; i++)
            {
                //sb.setCharAt(pos, fCharList[i]);

                sb.Replace(sb[pos], fCharList[i], pos, 1);

                if (pos == length - 1)
                {
                    // Write the Brute Force generated word.
                    Console.WriteLine(sb.ToString());
                }
                else
                {
                    ChangeCharacters(pos + 1, sb, length);
                }
            }

            return sb.ToString();
        }

    }
}

