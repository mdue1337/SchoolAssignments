using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkedListsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opgave 1

            Console.WriteLine("Opgave 1\n");

            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);

            foreach(int i in list)
            {
                Console.WriteLine($"{i}");
            }

            int index = 0;

            foreach(int i in list)
            {
                if(index == 2)
                {
                    list.Remove(i); break;
                }
                index++;
            }

            Console.WriteLine();

            foreach (int i in list)
            {
                Console.WriteLine($"{i}");
            }

            Console.WriteLine();

            // Opgave 2, ElementAt(index) kunne også være brugt.

            Console.WriteLine("Opgave 2\n");

            LinkedList<int> ints = new LinkedList<int>();

            ints.AddLast(2);
            ints.AddLast(4);
            ints.AddLast(5);
            ints.AddLast(2);
            ints.AddLast(8);
            ints.AddLast(1);
            ints.AddLast(9);
            ints.AddLast(3);
            ints.AddLast(4);
            ints.AddLast(10);

            // Sidste tal i listen

            int lastElement = ints.Last();

            Console.WriteLine($"{lastElement}, is the last element");

            // sum af sidste og 3 element

            int thridElement = 0;

            index = 0;

            foreach (int i in ints)
            {
                if (index == 2)
                {
                    thridElement = i; break;
                }
                index++;
            }

            int sum = lastElement + thridElement;

            Console.WriteLine($"Sum of {lastElement} + {thridElement}: {sum}");

            // Divider med 3 sidste tal

            int dividerNum = 0;
            index = 0;

            int dividerIndex = ints.Count - 3; // går 2 tal bagud og minuser med en ekstra grundet vi skal have index-værdien

            foreach(int i in ints)
            {
                if (index == dividerIndex)
                {
                    dividerNum = i; break;
                }
                index++;
            }

            int sum2 = sum / dividerNum;

            Console.WriteLine($"{sum2} is {sum} divided by {dividerNum}");

            // Multiplicer med listens 5 element

            int multiplicerElement = 5 - 1;
            int multiplicerValue = 0;
            index = 0;

            foreach (int i in ints)
            {
                if(index == multiplicerElement)
                {
                    multiplicerValue = i; break;
                }
                index++;
            }

            int sum3 = sum2 * multiplicerValue;

            Console.WriteLine($"The sum of {sum2} * {multiplicerValue}: {sum3}");

            // Modolus med første element

            int sum4 = sum3 % ints.First();

            Console.WriteLine($"Modolus of {sum3} and {ints.First()} is: {sum4}");

            Console.ReadKey();
        }
    }
}