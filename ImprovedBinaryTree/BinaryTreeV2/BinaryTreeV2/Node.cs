using System;

namespace BinaryTreeV2
{
    public class Node
    {
        public int? value { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }

        public Node(int? value)
        {
            this.value = value;
            Right = null;
            Left = null;
        }
    }
}
