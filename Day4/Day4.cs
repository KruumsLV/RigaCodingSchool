using System;
using System.Linq;

namespace Day4
{
    class Day4
    {
        static void Task1()
        {
            string[] masivs = {"Kristaps", "Kārlis", "Artrūs", "Anete", "Zane", "Edgars" };
            int i = 0;
            do
            {
                Console.WriteLine(masivs[i++]);
            } while (i < masivs.Length);
        }
        static void Task2()
        {
            int[] numbers = { 1, 3, 4, 8, 0, 23 };
            // Izdrukājam visas vērtības
            foreach(int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            //Izdrukājam vērtības, kuras ir lielākas par 5
            foreach(int number in numbers)
            {
                if (number > 5)
                {
                    Console.Write($"{number} ");
                }
            }
            Console.WriteLine();

            // Izmantojot LINQ:
            // Console.WriteLine(String.Join(", ", numbers.Where(num => num > 5)));
        }
        static void Task3()
        {
            string[] nameArray = { "Kristaps", "Jānis", "Zane", "Jēkabs", "Anete", "Jana", "Māris" };
            // Izdrukājam visus vārdus
            Console.WriteLine(String.Join(" ", nameArray));

            // Izdrukājam vārdus, kuri sākās ar "J"
            foreach(string name in nameArray)
            {
                if (name.Substring(0, 1).ToUpper().Equals("J"))
                {
                    Console.Write($"{name} ");
                }
            }
            Console.WriteLine();

            // Izmantojot LINQ:
            //Console.WriteLine(String.Join(" ", nameArray.Where(name => name.Substring(0, 1).ToUpper().Equals("J"))));

        }
        static void Task4()
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            Console.WriteLine(String.Join(",", array));
        }
        static void ExtraTask()
        {
            Console.WriteLine("Ievadi tekstu:");
            string inputText = Console.ReadLine();
            for(int i = inputText.Length - 1; i >= 0; i--)
            {
                Console.Write(inputText[i]);
            }
            Console.WriteLine();
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
                    case "2":
                        Task2();
                        break;
                    case "3":
                        Task3();
                        break;
                    case "4":
                        Task4();
                        break;
                    case "extra":
                        ExtraTask();
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
