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
                    for (int i = 0; i < 6; i ++)
                        Task1.PrintGreeting(); // izpildīt 3 reizes
                    break;
                case "2":
                    Console.Write("Ievadi vārdu: ");
                    string name = Console.ReadLine();
                    Console.Write("Ievadi uzvārdu: ");
                    string surname = Console.ReadLine();
                    Task2.PrintMyName(name, surname);
                    break;
                case "3":
                    Task3.PrintNameSurname(Task3.GetNameSurname());
                    break;
                case "extra":
                    Console.Write("Ievadi skatili n: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Faktoriāls no {n} ir { ExtraTask.Factorial(n) }");
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
