using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions.String.StringBuilder
{
    public class StringOperation
    {
        public static string reverseString(string str)
        {
            if(string.IsNullOrEmpty(str)) return str;

            var sb = new System.Text.StringBuilder(str.Length);

            Console.WriteLine(sb.ToString());

            for (int i = str.Length -1; i>=0; i--)
            {
                Console.WriteLine(i);
                sb.Append(str[i]);
            }
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }

        // to remove duplicate characters from a string using StringBuilder
        public static string RemoveDuplicates(string input)
        {
            if(string.IsNullOrEmpty(input)) return input;
            var sb = new System.Text.StringBuilder();
/*            var resinput = input.GroupBy(x => x);
            foreach( var item in resinput)
            {
                sb.Append(item.Key);
            }
*/          var seen = new HashSet<char>();

            foreach (char c in input)
            {
                if (!seen.Contains(c))
                {
                    Console.WriteLine(seen.ToArray());
                    seen.Add(c);
                    sb.Append(c);
                }
            }

            Console.WriteLine(sb.ToString());

            return sb.ToString();
        }

        public static string CompressString(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            var grouped = input
                .Select((c, i) => new { Char = c, Index = i })
                .GroupBy(x => x.Char, x => x.Index)
                .Select(g => g.Key.ToString() + g.Count());

            string result = string.Join("", grouped);

            Console.WriteLine(result.Length < input.Length ? result : input);
            return result.Length < input.Length ? result : input;


        }
    }
}

/*O/P
4
3
2
1
0
elppa*/