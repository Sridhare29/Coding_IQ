using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions.String
{
    public class chkPalindrome
    {
        public static void isPalindrome(string str)
        {
            string result = new string(str.Reverse().ToArray());
            Console.WriteLine(result == str ? $"{result} is Palindrome" : $"{result} is Not Palindrome");                
        }

        public static void isPalindrome1(string str)
        {
            var sb = new System.Text.StringBuilder(str);
            string reversed = new string(sb.ToString().Reverse().ToArray());
            Console.WriteLine(str == reversed ? "Palindrome" : "Not Palindrome");
        }
    }
}

/*char to string:

char c = 'X';
string s = c.ToString();  // "X"
string s2 = new string(c, 3);  // "XXX" (repeats char 3 times)


string to char[]:

string word = "Hello";
char[] chars = word.ToCharArray();  // ['H', 'e', 'l', 'l', 'o']
char firstChar = word[0];  // 'H' (access by index)
*/