using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    public class FizzBuzzTask
    {
        public IList<string> FizzBuzz(int n)
        {
            IList<string> result = new List<string>();
            for (int i = 1; i < n + 1; i++)
            {
                result[i - 1] = (i switch
                {
                    _ when i % 3 == 0 && i % 5 == 0 => "FizzBuzz",
                    _ when i % 3 == 0 => "Fizz",
                    _ when i % 5 == 0 => "Buzz",
                    _ => i.ToString()
                });
            }
            return result;
        }
    }
}
