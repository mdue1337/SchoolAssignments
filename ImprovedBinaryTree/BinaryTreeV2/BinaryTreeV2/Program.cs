using System;

namespace BinaryTreeV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node Root = null;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                else
                {
                    int value = int.Parse(input);
                    Root = InsertNode(value, Root);
                }
            }

            int target = int.Parse(Console.ReadLine());

            Node targetNode = PreOrderTraversel(Root, target);

            if(targetNode == null)
            {
                Console.WriteLine($"{target} not found in tree");
            }
            else
            {
                Console.WriteLine(targetNode.value);
            }

            Console.ReadKey();
        }

        public static Node InsertNode(int value, Node node)
        {
            if (node == null)
            {
                return new Node(value);
            }

            if (value <= node.value)
            {
                node.Left = InsertNode(value, node.Left);
            }
            else if (value >= node.value)
            {
                node.Right = InsertNode(value, node.Right);
            }

            return node;
        }

        public static Node PreOrderTraversel(Node node, int target)
        {
            if (node.value == target)
            {
                return node;
            }
            else
            {
                Console.WriteLine($"{node.value} is not {target}");
            }

            if(node.Left != null)
            {
                Node leftResult = PreOrderTraversel(node.Left, target);
                if (leftResult != null)
                {
                    return leftResult;
                }
            }
            
            if(node.Right != null)
            {
                Node RightResult = PreOrderTraversel(node.Right, target);
                if (RightResult != null)
                {
                    return RightResult;
                }
            }
            
            return null;
        }
    }
}
