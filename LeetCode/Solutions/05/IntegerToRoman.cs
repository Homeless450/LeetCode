using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._05
{
    internal class IntegerToRoman
    {
        public string IntToRoman(int num)
        {
            var dic = new Dictionary<int, string>();
            dic[1000] = "M";
            dic[900] = "CM";
            dic[500] = "D";
            dic[400] = "CD";
            dic[100] = "C";
            dic[90] = "XC";
            dic[50] = "L";
            dic[40] = "XL";
            dic[10] = "X";
            dic[9] = "IX";
            dic[5] = "V";
            dic[4] = "IV";
            dic[1] = "I";

            string answer = "";
            foreach (var kv in dic)
            {
                int div = num / kv.Key;
                for (int i = 0; i < div; i++)
                {
                    answer += kv.Value;
                }
                num %= kv.Key;
                if (num == 0)
                    break;
            }
            return answer;
        }

    }
}
