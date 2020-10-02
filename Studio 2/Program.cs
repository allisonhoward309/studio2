using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Studio_2
{
    public class Count
    {
        private static readonly Regex regex = new Regex("[^a-zA-Z0-9 _]");
        static void Main(string[] args)
        {
            Console.WriteLine("Enter message:");
            string text = Console.ReadLine().ToLower();
            string str = regex.Replace(text, String.Empty);
            str = str.Replace(" ", String.Empty);
            char[] charactersInString = str.ToCharArray();

            Dictionary<char, int> alphabet = new Dictionary<char, int>();



            foreach (char c in charactersInString)
            {
                if (!alphabet.Keys.Contains(c))
                {
                    alphabet.Add(c, 1);
                }
                else
                {
                    alphabet[c]++;
                }
            }
            foreach (KeyValuePair<char, int> a in alphabet)
            {
                Console.WriteLine(a.Key + ": " + a.Value);
            }


        }
    }
}
