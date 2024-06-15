using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2_Checking_if_a_string_is_a_palindrome
{
    internal class Program
    {
        static bool IsPalindrome(string str) 
        {
            int left =0;
            int right = str.Length-1;
            while (left < right) 
            {
                if(str[left] != str[right]) 
                {
                    return false;
                }
            left++;
            right--;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string input = "racecar";
            if (IsPalindrome(input))
            {
                Console.WriteLine($"{input} is a Palindrome");
            }
            else 
            {
                Console.WriteLine($"{input} is not a Palindrome");
            }
        }
    }
}
