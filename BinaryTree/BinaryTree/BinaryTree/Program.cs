using System;
using System.Security.Policy;
using System.Xml.Linq;

namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node ChildOneLeft = new Node(null);
            Node ChildOneRight = new Node(null);

            Console.WriteLine("Start value: ");
            int ui = int.Parse(Console.ReadLine());
            Node Parent = new Node(ui);

            bool userUsing = true;

            while (userUsing)
            {
                Console.WriteLine("Select value, node level, and side (1 for right, 2 for left)");
                Console.WriteLine("Node levels: 2, 3");
                Console.WriteLine("Side: 1, 2");
                Console.WriteLine("Example: 28 1 1");
                Console.WriteLine("Use enter to leave the program");

                string[] userInput = Console.ReadLine().Split(' ');

                if (userInput[0] == "")
                {
                    userUsing = false;
                }
                else
                {
                    int value = int.Parse(userInput[0]);
                    int level = int.Parse(userInput[1]);
                    int side = int.Parse(userInput[2]);

                    switch (level)
                    {
                        case 2:
                            if (side == 1)
                            {
                                HandleSwitchCase(side, Parent, value, ChildOneRight);
                            }
                            else if (side == 2)
                            {
                                HandleSwitchCase(side, Parent, value, ChildOneLeft);
                            }
                            break;
                        case 3:
                            if (ChildOneRight != null || ChildOneLeft != null)
                            {
                                Node temp = new Node(null);
                                if (side == 1)
                                {
                                    HandleSwitchCase(side, ChildOneRight, value, temp);
                                }
                                else if (side == 2)
                                {
                                    HandleSwitchCase(side, ChildOneLeft, value, temp);
                                }
                            }
                            break;
                        default:
                            userUsing = false;
                            break;
                    }
                }
            }

            Console.ReadKey();
        }

        static void NodeAddValueLeft(Node node, int value, Node Child)
        {
            if (value <= node.data)
            {
                if (node.Left == null)
                {
                    Child.data = value;
                    node.Left = Child;
                }
                else
                {
                    throw new Exception("Failed, because value exists");
                }
            }
        }

        static void NodeAddValueRight(Node node, int value, Node Child)
        {
            if (value >= node.data)
            {
                if (node.Right == null)
                {
                    Child.data = value;
                    node.Right = Child;
                }
                else
                {
                    throw new Exception("Failed, because value exists");
                }
            }
        }

        static void HandleSwitchCase(int side, Node node, int value, Node Child)
        {
            switch (side)
            {
                case 1: // right
                    NodeAddValueRight(node, value, Child);
                    break;
                case 2: // left
                    NodeAddValueLeft(node, value, Child);
                    break;
            }
        }
    }
}
