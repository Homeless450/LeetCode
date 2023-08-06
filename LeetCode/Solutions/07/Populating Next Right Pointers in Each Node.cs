using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Definition for a Node.
public class Node
{
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() { }

    public Node(int _val)
    {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next)
    {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}


namespace LeetCode.Solutions._07
{
    internal class Populating_Next_Right_Pointers_in_Each_Node
    {
        public Node Connect(Node root)
        {

            Queue<Node> Q = new Queue<Node>();
            if (root == null) return null;
            Q.Enqueue(root);

            while (Q.Count() > 0)
            {
                int qSize = Q.Count();
                while (qSize > 0)
                {
                    Node element = Q.Dequeue();
                    if (qSize > 1)
                    {
                        element.next = Q.Peek();
                    }
                    if (element.left != null) Q.Enqueue(element.left);
                    if (element.right != null) Q.Enqueue(element.right);

                    qSize--;
                }
            }
            return root;
        }
    }
}
