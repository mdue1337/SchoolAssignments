using System;

namespace BinaryTree
{
    public class Node
    {
        public int? data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int? value)
        {
            data = value;
            Left = null;
            Right = null;
        }
    }
}
