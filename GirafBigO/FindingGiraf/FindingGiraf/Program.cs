using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingGiraf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string>();

            // Fil ligger også i debug, det er derfor det virker!!!!!!!
            string path = @".\animals.txt";

            try
            {
                FileInfo fi = new FileInfo(path);
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                string line = "";

                while ((line = sr.ReadLine()) != null)
                {
                    animals.Add(line);
                }
                fs.Close();
                sr.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Fil kan ikke findes");
            }

            /*
             * Pseudokode Big(n):
             * 
             * 1. Start med at læse data fra fil
             * 2. Lav en list som kan huse de forskellige strings
             * 2. For hver element i listen udfør:
             *      2a. hvis elementet er lig med "giraf" udskriv indexet
             * 3. Slut foreløkke
             * 4. Nu du færdig
             */

            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i] == "Giraffe")
                {
                    Console.WriteLine($"{i}, er 'Giraffe' indexet");
                    break;
                }
            }

            /*
             * Pseudokode Big(log(n)):
             * 
             * 1. Start med at læse data fra fil
             * 2. Lav en list som kan huse de forskellige strings
             * 2. For hver element i listen udfør:
             *      2a. Hvis medianen af .count giver en element værdi som er højere eller laver alfabetmæssigt
             *          2ab. Her er element mindre og du kører derfor videre med første halvdel af .count
             *          2ac. Dette er så den anden halvdel
             *              2ad. Over eller under alphabetmæssigt bevæger du dig enten halvdelen tættere på eller halvdelen længere væk
             *                  2ae. Det gør du indtil du rammer elementet
             *      2b. hvis elementet er lig med "giraf" udskriv indexet
             * 3. Slut foreløkke
             * 4. Nu du færdig
             * 
            */

            int startnummerindex = 0, endnummerindex = animals.ToArray().Length - 1;

            string giraffe = "Giraffe";
            bool exitloop = false;
            while (!exitloop)
            {
                Random rnd = new Random();
                int randomindex = rnd.Next(startnummerindex, endnummerindex);

                if (animals[randomindex] == giraffe)
                {
                    Console.WriteLine("Giraffe was found at index: " + randomindex.ToString());
                    exitloop = true;

                }
                List<string> nyarray = new List<string>();
                nyarray.Add(animals[randomindex]);
                nyarray.Add(giraffe);
                nyarray.Sort();
                if (nyarray[0] != giraffe)
                {
                    startnummerindex = randomindex + 1;
                }
                else
                {
                    endnummerindex = randomindex - 1;
                }
            }
            Console.ReadKey();
        }
    }
}
