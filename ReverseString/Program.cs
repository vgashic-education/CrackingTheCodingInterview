using System;

namespace ReverseString {
    class Program {

        /// <summary>
        /// Write code to reverse a C-Style String.
        /// (C-String means that “abcd” is represented as five characters, including the null character.)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {

            string str = Console.ReadLine();

            // create C style string
            // size iz length of string + 1
            // last char will by default be null
            char?[] charArray = new char?[str.Length + 1];

            for (int i = 0; i < str.Length; i++) {
                charArray[i] = str[i];
            }

            var reverse = ReverseString(charArray);

            for (int i = 0; i < reverse.Length - 1; i++) {
                Console.Write(charArray[i]);
            }

            Console.ReadKey();

        }


        private static char?[] ReverseString(char?[] charArray) {

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
