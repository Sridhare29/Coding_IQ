using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions.String
{
    public class chkPalindrome
    {
        public string isPalindrome(string str)
        {
            string inputStr = "madam";

            string result = new string(inputStr.Reverse().ToString());

            return result;
        }
    }
}
