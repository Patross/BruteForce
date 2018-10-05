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
            'u', 'v', 'w', 'x', 'y', 'z','A','B','C','D','E'
        };

        static void Main(string[] args)
        {
            StartBruteForce(4);
        }

        /// <summary>
        /// Start Brute Force.
        /// </summary>
        /// <param name="length">Words length.</param>
        public static void StartBruteForce(int length)
        {
            StringBuilder sb = new StringBuilder(length);
            char currentChar = fCharList[0];

            for (int i = 1; i <= length; i++)
            {
                sb.Append(currentChar);
            }

            ChangeCharacters(0, sb, length);
        }

        private static StringBuilder ChangeCharacters(int pos, StringBuilder sb, int length)
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
                Thread.Sleep(150);
            }

            return sb;
        }

    }
}

