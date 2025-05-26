using System;
using System.Text;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;

namespace CodingQuestions.String.StringBuilder
{
    public class stringBuilderClass
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
/*      sb.Append("Hello");
        sb.Append(" ");
        sb.Append("World");

        Console.WriteLine(sb.ToString()); // Output: Hello World
*/    }
}



/*StringBuilder is a class in C# (found in System.Text namespace) used to efficiently build and modify strings, 
    especially in loops or when performing many string operations.

    
✅ Commonly used StringBuilder methods (in-built functions):
Method                  Purpose	                                              Example
.Append()	            Adds text to the end	                      sb.Append("hello");
.Insert(index, s)       Inserts string s at given index	              sb.Insert(0, "Hi ");
.Remove(start, len)     Removes characters from a string	          sb.Remove(0, 2);
.Replace(old, new)      Replaces all occurrences of a string	      sb.Replace("a", "x");
.ToString()             Converts StringBuilder back to string	      string result = sb.ToString();*/


