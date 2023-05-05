using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class MiddleOfTheLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {
            var len = 0;
            var nodehead = head;
            while (head != null)
            {
                len++;
                head = head.next;
            }

            var index = 0;
            while (len / 2 != index)
            {
                nodehead = nodehead.next;
                index++;
            }

            return nodehead;
        }
    }
}
