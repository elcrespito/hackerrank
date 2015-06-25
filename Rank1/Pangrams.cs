using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class Pangrams
    {
        static void solution(string text)
        {
            text = Console.ReadLine().ToUpper().Replace(" ", "");

            int sum = 0;
            for (int i = 0; i < LETTERS_COUNT; i++)
            {
                sum += i;
            }

            foreach (char key in text)
            {
                if (Alphabet[key] == false)
                {
                    Alphabet[key] = true;
                    sum -= (key - CHAR_DIFFERENCE);
                }
            }

            if (sum == 0)
            {
                Console.Write("pangram");
            }
            else
            {
                Console.Write("not pangram");
            }

            Console.ReadLine();
        }


        private static Dictionary<char, bool> Alphabet
        {
            get
            {
                if (_alphabet == null)
                {
                    _alphabet = new Dictionary<char, bool>();

                    for (int i = 0; i < LETTERS_COUNT; i++)
                    {
                        _alphabet.Add(Convert.ToChar(i + CHAR_DIFFERENCE), false);
                    }
                }

                return _alphabet;
            }
        }

        private static Dictionary<char, bool> _alphabet;

        private const int CHAR_DIFFERENCE = 65;
        private const int LETTERS_COUNT = 26;
    }
}
