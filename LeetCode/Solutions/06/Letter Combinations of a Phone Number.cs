using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._06
{
    internal class Letter_Combinations_of_a_Phone_Number
    {
        private Dictionary<char, string[]> _dictionary;

        public IList<string> LetterCombinations(string digits)
        {
            _dictionary = new Dictionary<char, string[]>()
            {
            { '2', new string[]{"a", "b", "c" }},
            { '3', new string[]{"d", "e", "f" }},
            { '4', new string[]{"g", "h", "i" }},
            { '5', new string[]{"j", "k", "l" }},
            { '6', new string[]{"m", "n", "o" }},
            { '7', new string[]{"p", "q", "r", "s" }},
            { '8', new string[]{"t", "u", "v" }},
            { '9', new string[]{"w", "x", "y", "z" }}
            };

            var result = new List<string>();
            if (string.IsNullOrEmpty(digits)) { return result; }

            if (digits.Length == 1)
            {
                result.AddRange(_dictionary[digits[0]]);
                return result;
            }

            var currentLetters = _dictionary[digits[0]];

            var permutation = LetterCombinations(digits.Substring(1));

            foreach (var letter in currentLetters)
            {
                foreach (var arrangement in permutation)
                {
                    result.Add(letter + arrangement);
                }
            }

            return result;
        }

    }
}
