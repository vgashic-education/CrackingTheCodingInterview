using System;
using System.Collections.Generic;

namespace AllUniqueCharacters {

    /// <summary>
    /// 1.1
    /// Implement an algorithm to determine if a string has all unique characters.
    /// What if you can not use additional data structures?
    /// </summary>
    class Program {

        static void Main(string[] args) {

            string inputString = string.Empty;

            do {

                inputString = Console.ReadLine();

                Console.WriteLine(AreAllCharactersUniqueDict(inputString));
                Console.WriteLine();

            } while (inputString.ToLower() != "q");


        }


        /// <summary>
        /// Solution using Dictionary
        /// </summary>
        /// <param name="stringToCheck"></param>
        /// <returns></returns>
        static bool AreAllCharactersUniqueDict(string stringToCheck) {

            bool allCharactersAreUnique = true;
            var dict = new Dictionary<char, int>();

            foreach (var item in stringToCheck) {

                if (dict.ContainsKey(item)) {
                    return false;
                }

                dict.Add(item, 1);

            }

            return allCharactersAreUnique;

        }





    }
}
