using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._07
{
    internal class Reverse_Words_in_a_String
    {
        public string ReverseWords(string s)
        {
            string[] words = s.Split(" ");

            List<string> words2 = new List<string>();
            
            foreach (string word in words)
            {
                if (word != "") words2.Add(word);
            }
            string[] arr = words2.ToArray();
            Array.Reverse(arr);
            string result = string.Join(" ", arr.ToArray());
            return result;
        }
    }
}
