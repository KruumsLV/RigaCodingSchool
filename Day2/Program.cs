using System;

namespace Day2
{
    class Program
    {
        static void Task1()
        {
            Console.WriteLine("----- Task 1 -----");
            int x, y;
            while(true)
            {
                Console.Write("Ievadi skaitli x: ");
                x = Convert.ToInt32(Console.ReadLine());
                
                if (x >= 0 && x <= 20)
                {
                    break;
                } 
                else
                {
                    Console.WriteLine("Kļūda! x nav robežās [0; 20]!");
                }
            }
            while (true)
            {
                Console.Write("Ievadi skaitli y: ");
                y = Convert.ToInt32(Console.ReadLine());
                if (y >= 30 && y <= 50)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Kļūda! y nav robežās [30; 50]!");
                }
            }

            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine("------------------");
        }
        static void Task2()
        {
            // a,b,c,d - 1.stāvs
            // e, f, g, h - 2.stāvs
            // i, j, k, l - 3.stāvs
            // m, n, o, p - 4.stāvs
            // r, s, t, u - 5.stāvs
            Console.WriteLine("----- Task 2 -----");
            Console.Write("Ievadi priekšmetu: ");
            string item = Console.ReadLine();
            char firstLetter = item.ToLower()[0];

            if (firstLetter == 'a' || firstLetter == 'b' || firstLetter == 'c' || firstLetter == 'd')
            {
                Console.WriteLine($"{item} - novietots 1.stāvā");
            }
            else if (firstLetter == 'e' || firstLetter == 'f' || firstLetter == 'g' || firstLetter == 'h')
            {
                Console.WriteLine($"{item} - novietots 2.stāvā");
            }
            else if (firstLetter == 'i' || firstLetter == 'j' || firstLetter == 'k' || firstLetter == 'l')
            {
                Console.WriteLine($"{item} - novietots 3.stāvā");
            }
            else if (firstLetter == 'm' || firstLetter == 'n' || firstLetter == 'o' || firstLetter == 'p')
            {
                Console.WriteLine($"{item} - novietots 4.stāvā");
            }
            else if (firstLetter == 'r' || firstLetter == 's' || firstLetter == 't' || firstLetter == 'u')
            {
                Console.WriteLine($"{item} - novietots 5.stāvā");
            }
            else
            {
                Console.WriteLine($"{item} - novietots pagrabā");
            }

            Console.WriteLine("------------------");
        }
        enum EglitesVeids
        {
            Tradicionala,
            Sudrabeglite
        }
        static void Task3()
        {
            Console.WriteLine("----- Task 3 -----");

            int input = 1;
            EglitesVeids eglitesVeids = (EglitesVeids)input;
            int augstums = 55;
            int zaruDiametrs = 149;

            if (eglitesVeids == EglitesVeids.Tradicionala)
            {
                if (augstums >= 50 && augstums < 100 && zaruDiametrs >= 100 && zaruDiametrs < 150)
                {
                    Console.WriteLine("Viesistaba 1");
                }
                else if (augstums >= 100 && augstums < 150 && zaruDiametrs >= 150 && zaruDiametrs < 200)
                {
                    Console.WriteLine("Viesistaba 2");
                }
                else if (augstums >= 150 && augstums <= 300 && zaruDiametrs >= 200 && zaruDiametrs <= 300)
                {
                    Console.WriteLine("Kamīnzāle");
                }
                else
                {
                    Console.WriteLine("Nav kur novietot eglīti! :(");
                }
            } 
            else
            {
                Console.WriteLine("Kamīnzāle");
            }

            Console.WriteLine("------------------");
        }
        static void ExtraTask()
        {
            Console.WriteLine("----- Extra Task -----");
            Console.Write("Ievadi pirmā spēlētāja vārdu: ");
            string firstPlayer = Console.ReadLine();
            Console.Write("Ievadi otrā spēlētāja vārdu: ");
            string secondPlayer = Console.ReadLine();

            Console.WriteLine($"3 reizes ievadi spēlētāja '{firstPlayer}' punktus: ");
            int playerOnePts = 0;
            for (int i = 1; i <= 3; i++)
            {
                playerOnePts += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"3 reizes ievadi spēlētāja '{secondPlayer}' punktus: ");
            int playerTwoPts = 0;
            for (int i = 1; i <= 3; i++)
            {
                playerTwoPts += Convert.ToInt32(Console.ReadLine());
            }

            if (playerOnePts != playerTwoPts)
            {
                Console.WriteLine($"Spēlētājs ar visvairāk punktiem: { (playerOnePts > playerTwoPts ? firstPlayer : secondPlayer) }");
            } 
            else
            {
                Console.WriteLine("Abiem spēlētājiem ir vienāds punktu skaits!");
            }

            Console.WriteLine("------------------");
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
