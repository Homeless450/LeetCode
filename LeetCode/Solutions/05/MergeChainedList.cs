using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._05
{
    internal class MergeChainedList
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2, ListNode result = null)
        {
            if (list1 == null && list2 == null)
            {
                return null;
            }
            else if (list1 == null)
            {
                int val = list2.val; list2 = list2.next;
                return new ListNode(val, MergeTwoLists(list1, list2, result));
            }
            else if (list2 == null)
            {
                int val = list1.val; list1 = list1.next;
                return new ListNode(val, MergeTwoLists(list1, list2, result));
            }
            else
            {
                int min = Math.Min(list1.val, list2.val);
                if (list2.val < list1.val)
                {
                    list2 = list2.next;
                }
                else
                {
                    list1 = list1.next;
                }
                return new ListNode(min, MergeTwoLists(list1, list2, result));
            }
        }
    }
}
