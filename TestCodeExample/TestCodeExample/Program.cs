namespace TestCodeExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int counter = 1;

            while (true)
            {
                Console.WriteLine($"Spil {counter}\n");

                int kast1 = rng.Next(1, 7);
                int kast2 = rng.Next(1, 7);

                int round1 = EvaluateRoll(kast1, kast2);
                WriteRoundOutcome(round1, "Spiller");

                kast1 = rng.Next(1, 7);
                kast2 = rng.Next(1, 7);

                var round2 = EvaluateRoll(kast1, kast2);
                WriteRoundOutcome(round2, "Computer");

                Console.WriteLine("\n"+ Winner(round1, round2) + "\n");

                Console.WriteLine("Vil du spille igen?\nIndtast enhver knap og tryk enter for at fortsætte eller tryk blot enter for at afslutte");
                var input = Console.ReadLine();

                if (input.Length < 1)
                {
                    break;
                }

                counter++;

                Console.Clear();
            }
        }

        public static void WriteRoundOutcome(int round, string player)
        {
            int[] checkArray = { 101, 102, 103, 104, 105, 106 };
            bool exists = checkArray.Any(item => item == round);

            if (exists == true)
            {
                int lastNum = round % 10;
                Console.WriteLine($"{player} kast: par {lastNum}");
            }
            else if (round == 110)
            {
                Console.WriteLine($"{player} kast: Lille meyer");
            }
            else if (round == 120)
            {
                Console.WriteLine($"{player} kast: Meyer");
            }
            else
            {
                Console.WriteLine($"{player} kast: {round}");
            }
        }

        public static int EvaluateRoll(int kast1, int kast2)
        {
            if (kast1 > 6 || kast2 > 6 || kast1 < 0 || kast2 < 0)
            {
                throw new Exception("Ingen tal over 6 eller negative tal");
            }

            if (kast1 == kast2)
            {
                return 100 + kast1; // max 106
            }
            else if ((kast1 == 1 && kast2 == 3) || (kast1 == 3 && kast2 == 1))
            {
                return 110; // lille meyer
            }
            else if ((kast1 == 1 && kast2 == 2) || (kast1 == 2 && kast2 == 1))
            {
                return 120; // store meyer
            }
            else
            {
                return Math.Max(kast1, kast2) * 10 + Math.Min(kast1, kast2); // største mulige sammensættelse, max 65
            }
        }

        public static string Winner(int round1, int round2)
        {
            if (round1 > round2)
            {
                return "Spiller vinder";
            }
            else if (round2 > round1)
            {
                return "Computer vinder";
            }
            else
            {
                return "Ingen vinder";
            }
        }
    }
}