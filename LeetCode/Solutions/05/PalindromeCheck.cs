using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    public class PalindromeCheck
    {
        public bool IsPalindrome(ListNode head)
        {
            List<int> firstHalfe = new List<int>();
            List<int> lastHalfe = new List<int>();

            var len = 0;
            var nodehead = head;
            while (head != null)
            {
                len++;
                head = head.next;
            }
            if (len == 1)
                return true;

            var index = 0;
            while (len / 2 != index)
            {
                firstHalfe.Add(nodehead.val);
                nodehead = nodehead.next;
                index++;
            }

            if (len%2 != 0)
            {
                nodehead = nodehead.next;
            }

            while (index != 0)
            {
                lastHalfe.Add(nodehead.val);
                nodehead = nodehead.next;
                index--;
            }

            lastHalfe.Reverse();
            return Enumerable.SequenceEqual(firstHalfe, lastHalfe);
        }
    }
}
