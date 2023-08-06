using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._07
{
    internal class Linked_List_Cycle
    {
        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> listNodes = new HashSet<ListNode>();

            while (head != null)
            {
                if (listNodes.Contains(head)) return true;
                listNodes.Add(head);
                head = head.next;
            }

            return false;
        }
    }
}
