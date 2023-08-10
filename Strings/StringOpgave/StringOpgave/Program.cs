using System;

namespace StringOpgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Kald det kærlighed";
            Console.WriteLine($"Orginale string: {str}\n");

            // 1
            Console.WriteLine("- 1 -");

            string substr1 = str.Substring(9, 9);

            Console.WriteLine(substr1 + "\n");

            // 2
            Console.WriteLine("- 2 -");

            int æ = str.LastIndexOf('æ');

            string substr2 = str.Substring(æ, 1);

            Console.WriteLine($"{substr2}\n");

            // 3
            Console.WriteLine("- 3 -");

            int indexE = str.LastIndexOf('e');

            Console.WriteLine($"last index of 'e': {indexE}\n");

            // 4
            Console.WriteLine("- 4 -");

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'd')
                {
                    str = str.Replace('d', 'p');
                }
            }

            Console.WriteLine(str + "\n");

            // 5
            Console.WriteLine("- 5 -");

            int sum = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'p')
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum + "\n");

            // 6
            Console.WriteLine("- 6 -");

            string[] strSplit = str.Split(' ');

            for (int i = 0; i < strSplit.Length; i++)
            {
                Console.WriteLine($"{i+1}: {strSplit[i]}");
            }

            Console.ReadKey();
        }
    }
}
