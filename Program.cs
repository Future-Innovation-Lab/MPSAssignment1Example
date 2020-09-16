using System;
using Utilities;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToReverse = "This string needs to be backwards";

            string stringToDisplay = TextUtil.ReverseString(stringToReverse);
            Console.WriteLine(stringToDisplay);

            bool palindrome = TextUtil.IsPalindrome(stringToReverse);

            if (palindrome)
                Console.WriteLine(stringToReverse + " is a palindrome  ");
            else
                Console.WriteLine(stringToReverse + " is not a palindrome  ");


            stringToDisplay = TextUtil.ReverseStringVersion2(stringToReverse);
            Console.WriteLine("V2: " + stringToDisplay);
        }
    }
}
