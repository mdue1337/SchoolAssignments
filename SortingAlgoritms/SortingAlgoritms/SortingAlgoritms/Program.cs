using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingAlgoritms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 12, 16, 2, 28, 19};
            BubbleSort(ints);

            Console.WriteLine("Bubblesort");

            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine($"{i+1}: {ints[i]}");
            }

            Console.WriteLine("\nInsertion sort");

            int[] ints2 = ints.ToArray();

            InsertionSort(ints2);

            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {ints2[i]}");
            }

            int[] values = { 2, 1, 4, 4, 3, 5, 6, 9, 6, 8 };

            Console.WriteLine("\nQuicksort");

            int[] ints3 = QuickSort(values, 0, values.Length - 1);

            Console.WriteLine();

            for (int i = 0; i < ints3.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {ints3[i]}");
            }

            Console.WriteLine("\nMergeSort");

            int[] MergeSort = SortArray(values, 0, values.Length - 1);

            for (int i = 0; i < MergeSort.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {MergeSort[i]}");
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

        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j =- 1;
                }
                arr[j + 1] = key;
            }
        }

        public static void MergeArray(int[] array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];
            int i, j;

            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[middle + 1 + j];

            i = 0;
            j = 0;
            int k = left;

            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    array[k++] = leftTempArray[i++];
                }
                else
                {
                    array[k++] = rightTempArray[j++];
                }
            }

            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }

            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }
        }

        public static int[] SortArray(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                SortArray(array, left, middle);
                SortArray(array, middle + 1, right);

                MergeArray(array, left, middle, right);
            }

            return array;
        }

        public static int[] QuickSort(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            Console.WriteLine($"Current pivot point: {pivot}");

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    Console.WriteLine($"Switched: {array[i]} to {array[j]}");
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                QuickSort(array, leftIndex, j);
            if (i < rightIndex)
                QuickSort(array, i, rightIndex);

            return array;
        }
    }
}