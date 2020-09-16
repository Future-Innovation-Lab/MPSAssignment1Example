using System;

namespace Utilities
{
    public class TextUtil
    {
         public static string ReverseString(string inputString)
        {
            string reversedString = string.Empty;

            for (int counter = inputString.Length - 1; counter >= 0; counter--)
            {
                reversedString = reversedString + inputString[counter];
            }

            return reversedString;
        }

        public static string ReverseStringVersion2(string inputString)
        {
            string reversedString = string.Empty;

            int counter = inputString.Length - 1;

            while (counter >= 0)
            {
                reversedString = reversedString + inputString[counter];
                counter = counter - 1;

            }
            return reversedString;
        }


        public static bool IsPalindrome(string inputString)
        {
            string reversedString = ReverseString(inputString);

            if (inputString == reversedString)
                return true;
            else
                return false;
        }

    }

}