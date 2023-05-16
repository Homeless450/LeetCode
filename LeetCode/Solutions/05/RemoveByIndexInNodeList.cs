using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._05
{
    internal class RemoveByIndexInNodeList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode prev = null;

            for (var (node, i) = (head, 0); node != null; node = node.next, i++)
                if (i >= n)
                    if (prev == null) prev = head;
                    else prev = prev.next;

            if (prev == null) return head.next;
            if (prev.next != null) prev.next = prev.next.next;
            return head;
        }
    }
}