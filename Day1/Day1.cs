using System;

namespace Day1
{
    class Day1
    {
        static void Task1()
        {
            string name = "Kristaps";
            string lastName = "Krūmiņš";
            Console.WriteLine(String.Format("{0} {1}", name, lastName));
        }
        static void Task2()
        {
            //Deklarēšana
            int intNum;
            bool check;

            // Deklarēšana UN vērtibas piešķiršana - inicializācija
            //Initializing a variable means specifying an initial value to assign to it 
            //(i.e., before it is used at all).
            double doubleNum = 0.4155;
            string str = "ABC";

            //Vērtību piešķiršana
            intNum = 10;
            check = true;

            Console.WriteLine($"{intNum} {check} {doubleNum:0.##} {str}");
        }
        static void Task3()
        {
            int x = 10, y = 15;
            int z = x + y;
            Console.WriteLine(z);
        }
        static void Task4()
        {
            Console.Write("Ievadi savu vārdu: ");
            string name = Console.ReadLine();
            Console.WriteLine("Sveiks, " + name + "!");
        }
        static void Task5()
        {
            Console.Write("Ievadi savu vārdu: ");
            string name = Console.ReadLine();
            Console.Write("Ievadi savu uzvārdu: ");
            string lastName = Console.ReadLine();
            Console.WriteLine($"{name} {lastName}");
            Console.WriteLine($"{name.Substring(0, 1).ToUpper()}. {lastName}");
        }
        static void ExtraTask()
        {
            Console.Write("Ievadi skaitli a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadi skaitli b:");
            int b = Convert.ToInt32(Console.ReadLine());

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("Hehe, es apmainīju tavus skaitļus ar vietām...");
            Console.WriteLine($"a: {a}, b:{b}");
        }
        static void Main(string[] args)
        {
            Console.Write("Ievadi uzdevuma nr.: ");
            string taskNr = Console.ReadLine();

            switch(taskNr.Trim())
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
                    ExtraTask();
                    break;
                default:
                    Console.WriteLine("Such task does not exist!");
                    break;
            }
        }
    }
}
