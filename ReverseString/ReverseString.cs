using Helper;
using System;

namespace ReverseString {
    class ReverseString {

        /// <summary>
        /// Write code to reverse a C-Style String.
        /// (C-String means that “abcd” is represented as five characters, including the null character.)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {

            string str = Console.ReadLine();

            var reverse = ReverseCStyleString(str.ToCStyleString());

            Console.WriteLine(reverse.ConvertToString());

            Console.ReadKey();

        }


        private static char?[] ReverseCStyleString(char?[] charArray) {

            // length without last null character
            int realLength = charArray.Length - 1;

            for (int i = 0; i < realLength / 2; i++) {

                int posRev = realLength - 1 - i;

                char? swap = charArray[posRev];
                charArray[posRev] = charArray[i];
                charArray[i] = swap;

            }

            return charArray;

        }
    }
}
