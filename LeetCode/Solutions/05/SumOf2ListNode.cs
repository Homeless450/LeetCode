using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class SumOf2ListNode
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0)
        {
            if (l1 == null && l2 == null && carry == 0)
            {
                return null;
            }
            else if (l1 == null && l2 == null)
            {
                return new ListNode(carry, AddTwoNumbers(l1.next, l2.next, carry));
            }
            int total = l1.val + l2.val + carry;
            carry = total / 10;

            return new ListNode(total % 10, AddTwoNumbers(l1.next, l2.next, carry));
        }
    }
}
