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
                case "exit":
                    return;
                default:
                    Console.WriteLine($"Uzdevums '{ taskNr.Trim() }' neeksistē!");
                    break;
            }
        }
    }
}
