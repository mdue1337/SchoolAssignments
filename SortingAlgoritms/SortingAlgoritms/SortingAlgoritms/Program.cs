using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgoritms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 12, 16, 2, 28, 19};
            BubbleSort(ints);

            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine($"{i+1}: {ints[i]}");
            }

            Console.WriteLine();

            List<int> ints2 = ints.ToList();
            int value = 13;
            InsertionSort(ints2, value);

            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {ints2[i]}");
            }

            Console.ReadKey();
        }

        public static void BubbleSort(int[] array1)
        {
            int n = array1.Length;
            bool swapped = false;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array1[j] > array1[j + 1])
                    {
                        int switchValue = array1[j];
                        array1[j] = array1[j + 1];
                        array1[j + 1] = switchValue;
                        swapped = true;
                    }
                }
            }

            if(swapped == true)
            {
                BubbleSort(array1);
            }
        }

        public static void InsertionSort(List<int> list, int value)
        {
            int n = list.Count;
            int i = n - 1;

            while (i >= 0 && value < list[i])
            {
                i--;
            }

            Console.WriteLine($"Inserted value at index: {i + 2}");

            list.Insert(i + 1, value);
        }
    }
}
