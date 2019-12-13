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

                Console.WriteLine($"Dictionary: {AreAllCharactersUniqueDict(inputString)}");
                Console.WriteLine($"Array: {AreAllCharactersUniqueArray(inputString)}");
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


        /// <summary>
        /// Solution using array
        /// Pretty much same as dictionary solution
        /// </summary>
        /// <param name="stringToCheck"></param>
        /// <returns></returns>
        static bool AreAllCharactersUniqueArray(string stringToCheck) {

            bool allCharactersAreUnique = true;
            var arr = new char[stringToCheck.Length];

            for (int i = 0; i < stringToCheck.Length; i++) {

                if (Array.IndexOf(arr, stringToCheck[i]) > -1) {
                    return false;
                }

                arr[i] = stringToCheck[i];

            }

            return allCharactersAreUnique;

        }





    }
}
