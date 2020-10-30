using System;
using System.Collections.Generic;

namespace Day4
{
    class Day4
    {
        static void Task1()
        {
            string[] masivs = {"Kristaps", "Kārlis", "Artrūs", "Anete", "Zane",
                                "Edgars" };
            int i = 0;
            do
            {
                Console.WriteLine(masivs[i++]);
            } while (i < masivs.Length);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ievadi uzdevuma nr. vai exit, lai iziet no programmas.");
                string taskNr = Console.ReadLine();

                switch (taskNr.Trim())
                {
                    case "1":
                        Task1();
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
}
