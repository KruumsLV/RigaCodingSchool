using System;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi uzdevuma nr. vai exit, lai iziet no programmas.");
            string taskNr = Console.ReadLine();
            switch (taskNr.Trim())
            {
                case "1":
                    TicTacToe.Program.Main(new string[0]);
                    break;
                case "2":
                    Task2.PrintNameSurname("Kristaps Krūmiņš");
                    Task2.PrintNameSurname("Kristaps", "Krūmiņš");
                    Task2.PrintNameAge("Kristaps");
                    Task2.PrintNameAge("Kristaps", 24);
                    break;
                case "3":
                    int[] intArray = { 1, 3, 5, 2, 7, 13 };
                    string[] stringArray = { "a", "Asd" };
                    Task3.PrintArrayValues(stringArray);
                    Task3.PrintArrayValues(intArray);
                    break;
                case "4":
                    string[] nameArray = { "Jānis", "   ", "Pēteris", "Antons", "", "Andris" };
                    Task3.PrintArrayValues(nameArray);
                    nameArray = Task4.GetNonEmptyArray(nameArray);
                    Task3.PrintArrayValues(nameArray);
                    break;
                case "5":
                    Console.WriteLine(Task5.CalculateSum(3, 5));
                    Console.WriteLine(Task5.CalculateSum(556, 127));
                    Console.WriteLine(Task5.CalculateSum(-13, 17));
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
