using System;
using System.Text;

namespace Helper {

    public static class ExtensionMethods {

        /// <summary>
        /// create C style string
        /// last char will by default be null
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static char?[] ToCStyleString(this string str) {

            char?[] charArray = new char?[str.Length + 1];

            for (int i = 0; i < str.Length; i++) {
                charArray[i] = str[i];
            }

            return charArray;

        }


        public static string ConvertToString(this char?[] arr) {

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < arr.Length; i++) {
                
                if (arr[i] != '\0' && arr[i] != null) {
                    stringBuilder.Append(arr[i]);
                }

            }

            return stringBuilder.ToString();

        }

    }

}
