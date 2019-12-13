using System;
using System.Linq;

namespace RemoveDuplicatesFromString {

    /// <summary>
    /// Design an algorithm and write code to remove the duplicate characters in a string without using any additional buffer.
    /// NOTE: One or two additional variables are fine. An extra copy of the array is not.
    /// 
    /// FOLLOW UP
    /// Write the test cases for this method.
    /// </summary>
    class Program {

        static void Main(string[] args) {

            string str = Console.ReadLine();

            Console.WriteLine(RemoveDuplicatesLinq(str));
            Console.WriteLine(RemoveDuplicates(str));

        }


        /// <summary>
        /// Solution using linq
        /// Working correctly, but uses additional array
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static string RemoveDuplicatesLinq(string str) {

            var arr = str.ToCharArray();

            string onlyUnique = new string(arr.Distinct().ToArray());

            return onlyUnique;

        }


        static string RemoveDuplicates(string str) {



        }

    }
}
