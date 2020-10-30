using System;

namespace Day3
{
    class Day3
    {
        static void Task1()
        {
            int[] array = { 1, 6, 7, 78, 9, 9 };
            Console.WriteLine(String.Join(", ", array));
        }
        static void Task2()
        {
            // bool.Parse izmetīs kļūdu, ja nespēs konvērtēt string vērtību
            // piemēram, ievadot jebko, kas nav ne true, ne false - būs kļūda!
            // tāpēc tika izmantots try/catch bloks, lai šādu kļūdu noķertu
            // Alternatīva - izmantot bool.TryParse
            while(true)
            {
                Console.WriteLine("Vai Tu vēlies pusdienas? (TRUE/FALSE)");
                string input = Console.ReadLine();
                try
                {
                    if (bool.Parse(input))
                    {
                        Console.WriteLine("Jūsu pusdienas ir gatavas!");
                    }
                    else
                    {
                        Console.WriteLine("Jums pusdienas nebūs...");
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Nesapratu...");
                }
            }
        }
        static void Task3()
        {
            bool myBoolean = true;
            //ar while
            int i = 0;
            while (myBoolean)
            {
                if (++i == 20)
                    myBoolean = false;
            }

            // ar do/while
            /*int i = 0;
            do
            {
                if (++i == 20)
                    myBoolean = false;
            } while (myBoolean);*/

            // Ar for
            /*for(int i = 1; myBoolean; i++)
            {
                Console.WriteLine(i);
                if (i == 20)
                    myBoolean = false;
            }*/
        }
        static void Task4()
        {
            Console.WriteLine("Cik reizes?");
            int times = 0;
            while(!int.TryParse(Console.ReadLine(), out times) || times <= 0)
            {
                Console.WriteLine("Mēģini vēlreiz... (ievadi skaitli, kas ir lielāks par 0");
            }
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Hello world!");
            }
        }
        static void Task5()
        {
            int[] array = { 100, 200, 233, 66, 77, 98 };
            Console.WriteLine($"Pirmais elements: {array[0]}");
            Console.WriteLine($"Pedējais elements: {array[array.Length - 1]}");
        }
        static void Task6()
        {
            int[] array = { 7, 4, 7, 3, 6, 9, 2 };
            Console.WriteLine($"Original: { String.Join(", ", array) }");
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == 3)
                {
                    array[i] = 10;
                }
            }
            Console.WriteLine($"Edited: { String.Join(", ", array) }");
        }
        static void Task7()
        {
            string[] array = { "Jānis", "Pēteris", "Andris" };
            Console.WriteLine(array[1]);
            array[2] = "Jēkabs";
        }
        enum NedelasDienas
        {
            Pirmdiena,
            Otrdiena,
            Tresdiena,
            Ceturtdiena,
            Piektdiena,
            Sestdiena,
            Svetdiena
        }
        static void Task8()
        {
            NedelasDienas diena = NedelasDienas.Piektdiena;
            Console.WriteLine(diena);
        }
        static void ExtraTask()
        {
            Console.Write("Ievadi skaitli (1-20):");
            int x;
            while (!int.TryParse(Console.ReadLine(), out x) || x > 20 || x < 1)
            {
                Console.WriteLine("Kļūda! Ievadi skaitli (1-20): ");
            }
            int i = 1;
            while(i <= x)
            {
                int j = 1;
                while(j <= x)
                {
                    Console.Write($"{i * j++} ");
                }
                i++;
                Console.WriteLine();
            }
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
                    Task2();
                    break;
                case "3":
                    Task3();
                    break;
                case "4":
                    Task4();
                    break;
                case "5":
                    Task5();
                    break;
                case "6":
                    Task6();
                    break;
                case "7":
                    Task7();
                    break;
                case "8":
                    Task8();
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
