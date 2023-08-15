using System;
using System.Collections.Generic;

namespace VacationBookingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vacation> KundeList1 = new List<Vacation>();
            Kunde kunde = new Kunde(1, "Hans", "1234", KundeList1);

            List<Vacation> VacationOptions = new List<Vacation>();
            Vacation Afrika = new Vacation(1, "Afrika", 2999.99, 20);
            Vacation Asien = new Vacation(2, "Asien", 3709.12, 16);

            VacationOptions.Add(Afrika);
            VacationOptions.Add(Asien);

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("1. To book a vacations");
                Console.WriteLine("2. To see current tickets");
                Console.WriteLine("3. To unbook a vacation");
                Console.WriteLine("Type any other number to exit program");
                try
                {
                    int userInput = int.Parse(Console.ReadLine());
                    switch (userInput)
                    {
                        case 1:
                            Console.WriteLine("Available vacations:");
                            for (int i = 0; i < VacationOptions.Count; i++)
                            {
                                if (VacationOptions[i].stock > 0)
                                {
                                    Console.WriteLine($"VacationId: {VacationOptions[i].VacationId}, Destination: {VacationOptions[i].Destination}, Price: {VacationOptions[i].price}, Stock: {VacationOptions[i].stock}");
                                }
                                else
                                {
                                    break;
                                }
                            }
                            try
                            {
                                Console.WriteLine("What Id do you want?");
                                int userInput2 = int.Parse(Console.ReadLine());
                                kunde.Vacations.Add(VacationOptions[userInput2-1]);
                                VacationOptions[userInput2 - 1].stock = VacationOptions[userInput2 - 1].stock - 1;
                                Console.WriteLine($"Booked: {VacationOptions[userInput2-1].Destination}");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case 2:
                            for (int i = 0; i < kunde.Vacations.Count; i++)
                            {
                                Console.WriteLine($"{kunde.Vacations[i].Destination}, til {kunde.Vacations[i].price} kr.");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Your vacations:");
                            for (int i = 0; i < kunde.Vacations.Count; i++)
                            {
                                Console.WriteLine($"Id: {kunde.Vacations[i].VacationId} til {kunde.Vacations[i].Destination}");
                            }
                            try
                            {
                                Console.WriteLine("Do you want to unbook one of the vacations? (y/n)");
                                string userInput3 = Console.ReadLine();
                                if (userInput3.Equals("y"))
                                {
                                    Console.WriteLine("Which vacationId do you want to unbook?");
                                    int userinput4 = int.Parse(Console.ReadLine());
                                    for (int i = 0; i < kunde.Vacations.Count; i++)
                                    {
                                        if (kunde.Vacations[i].VacationId == userinput4)
                                        {
                                            kunde.Vacations.Remove(kunde.Vacations[i]);
                                            VacationOptions[userinput4 - 1].stock = VacationOptions[userinput4 - 1].stock + 1;
                                        }
                                    }
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        default:
                            isRunning = false;
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.ReadKey();
        }
    }
}