using System;

namespace PracticalProjectsSolutions
{
    public static class Text
    {
        // Fizz Buzz
        // Write a program that prints the numbers from 1 to 100. But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. For numbers which are multiples of both three and five print “FizzBuzz”.
        public static string[] FizzBuzz(int n)
        {
            string[] returnValue = new string[n];

            for(int i=0;i<n;++i)
            {
                int currentNum = i + 1;
                bool divisibleByThree = (currentNum%3==0);
                bool divisibleByFive = (currentNum%5==0);

                if(divisibleByFive&&divisibleByThree)
                {
                    returnValue[i] = "FizzBuzz";
                }
                else if(divisibleByThree)
                {
                    returnValue[i] = "Fizz";
                }
                else if(divisibleByFive)
                {
                    returnValue[i] = "Buzz";
                }
                else
                {
                    returnValue[i] = currentNum.ToString();
                }
            }

            return returnValue;
        }

        // Reverse a String
        // Enter a string and the program will reverse it and print it out.
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Count Vowels
        // Enter a string and the program counts the number of vowels in the text. For added complexity have it report a sum of each vowel found.
        public static int CountVowels(string s)
        {
            int returnValue = 0;

            // hardcode the vowels
            string vowels = "aeiou";

            // iterate through chars in string
            foreach (char c in s)
            {
                if(vowels.IndexOf(c)>-1)
                    returnValue++;
            }

            // if we have no vowels.. go back and count # of 'y'
            if(returnValue==0)
            {
                foreach(char c in s)
                {
                    if(c=='y')
                        returnValue++;
                }
            }

            return returnValue;
        }
        
        // Check If Palindrome
        // Checks if the string entered by the user is a palindrome. That is that it reads the same forwards as backwards like “racecar”
        public static bool CheckForPalindrome(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray)==s;
        }

        // Count Words in a String
        // Counts the number of individual words in a string. For added complexity read these strings in from a text file and generate a summary.
        public static int CountWordsInString(string words)
        {
            char[] delimeters = new char[] { ' ', '\r', '\n' };
            return words.Split(delimeters,StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
