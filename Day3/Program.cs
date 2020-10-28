using System;

namespace Day3
{
    class Program
    {
        static void Task1()
        {
            int[] array = { 1, 6, 7, 78, 9, 9 };
            Console.WriteLine(String.Join(", ", array));
        }
        static void Task2()
        {
            // Convert.ToBoolean
            // bool.Parse

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi uzdevuma nr. vai exit, lai iziet no programmas.");

            string taskNr = Console.ReadLine();
            switch (taskNr.Trim())
            {
                case "1":
                    Task1();
                    break;
                case "2":
                    //Task2();
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
