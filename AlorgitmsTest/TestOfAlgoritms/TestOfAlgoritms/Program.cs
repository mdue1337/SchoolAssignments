using System;

namespace TestOfAlgoritms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Sorting _s = new Sorting();
            int index = 0;
            List<int> nums = new();

            while (true)
            {
                Console.WriteLine("Please enter a number to add to the list");

                int flow = 0;
                if (index != 0 && index % 2 == 0)
                {
                    Console.WriteLine("The number must be bigger than " + nums[index - 1]);
                    flow = 1;
                }
                else if (index != 0)
                {
                    Console.WriteLine("The number must be smaller than " + nums[index - 1]);
                    flow = 2;
                }

                try
                {
                    int input = int.Parse(Console.ReadLine());

                    if (index == 0)
                    {
                        nums.Add(input);
                        index++;
                        continue;
                    }

                    if (flow == 1 && input > nums[index - 1])
                    {
                        nums.Add(input);
                    }
                    else if (flow == 2 && input < nums[index - 1])
                    {
                        nums.Add(input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please follow the specified rules.");
                        continue; // Skip the rest of the loop and ask for input again
                    }

                    index++;

                    Console.WriteLine("Please enter 'n' if you don't want to add any more nums to the collection, otherwise just press enter");
                    string userChar2 = Console.ReadLine();
                    if (userChar2 == "n")
                    {
                        break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine("Resulting collection:");
            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine($"{i}: {nums[i]}");
            }

            int[] MergeSort = _s.SortArray(nums.ToArray(), 0, nums.Count - 1);
        }
    }
}