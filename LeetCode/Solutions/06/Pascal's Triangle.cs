using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._06
{
    internal class Pascal_s_Triangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                List<int> list = new List<int>();
                for (int j = 0; j < i+1; j++)
                {
                    if (j != 0 && j != i)
                    {
                        list.Add(result[i - 1][j - 1] + result[i - 1][j]);
                    }
                    else list.Add(0);
                }
                result.Add(list);
            }
            return result;
        }

    }
}
