using System;
using System.Linq;

namespace Anagram {
    class Anagram {

        /// <summary>
        /// Write a method to decide if two strings are anagrams or not.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {

            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            Console.WriteLine(CheckIfAnagrams(str1, str2));

        }


        public static bool CheckIfAnagrams(string str1, string str2) {

            string str1Sorted = string.Join("", str1.ToCharArray().ToList().OrderBy(a => a.ToString()));
            string str2Sorted = string.Join("", str2.ToCharArray().ToList().OrderBy(a => a.ToString()));

            return str1Sorted == str2Sorted;

        }

    }
}
