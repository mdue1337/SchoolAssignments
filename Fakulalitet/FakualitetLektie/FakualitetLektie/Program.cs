using System;

namespace FakualitetLektie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a number you want to factorial:");
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(Faktualitet(num));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }

        static int Faktualitet(int num)
        {
            if(num == 0)
            {
                return 1;
            }
            else
            {
                return num * Faktualitet(num - 1);
            }
        }
    }
}
