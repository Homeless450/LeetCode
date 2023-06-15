using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._06
{
    internal class Swap_Nodes_in_Pairs
    {
        public ListNode SwapPairs(ListNode head, bool destinastion = true, int prev = 0)
        {
            if (head == null)
            {
                return null;
            }
            else if (head.next == null && destinastion)
            {
                return head;
            }
            else if (head.next == null && destinastion == false)
            {
                return new ListNode(prev, SwapPairs(head.next, true));
            }
            else if (destinastion)
            {
                return new ListNode(head.next.val, SwapPairs(head.next, false, head.val));
            }
            else
            {
                return new ListNode(prev, SwapPairs(head.next, true));
            }
        }
    }
}