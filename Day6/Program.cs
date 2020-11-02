using System;
using System.Text;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi uzdevuma nr. vai exit, lai iziet no programmas.");
            // asdsad
            string taskNr = Console.ReadLine();
            switch (taskNr.Trim())
            {
                case "1":
                    for(int i = 0; i < 3; i ++)
                        Task1.PrintGreeting(); // izpildīt 3 reizes
                    break;
                case "3":
                    Task3.PrintNameSurname(Task3.GetNameSurname());
                    break;
                case "exit":
                    return;
                default:
                    Console.WriteLine($"Uzdevums '{ taskNr.Trim() }' neeksistē!");
                    break;
            }
        }
    }
}
