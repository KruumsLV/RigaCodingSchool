using System;
using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;

namespace Day3
{
    class Program
    {
        static void Task1()
        {
            // Izveidot masīvu
            // Izvadīt tā saturu uz ekrāna
            // 1.variants:
            // for(int i = 0; i < masivs.Length; i++) 
            // { izvadām masīva elementus }
            // 2.variants: String.Join
        }
        static void Task2()
        {
            // Convert.ToBoolean
            // bool.Parse

        }
        enum MyEnum
        {
            Enum1 = 1,
            Enum2 = 2
        }
        static void Main(string[] args)
        {
            string text = "abc";
            char c = text[2];
            Console.WriteLine(c);

            //Console.WriteLine("Ievadi uzdevuma nr. vai exit, lai iziet no programmas.");

            //string taskNr = Console.ReadLine();
            //switch (taskNr.Trim())
            //{
            //    case "1":
            //        //Task1();
            //        break;
            //    case "2":
            //        //Task2();
            //        break;
            //    case "exit":
            //        return;
            //    default:
            //        Console.WriteLine($"Uzdevums '{ taskNr.Trim() }' neeksistē!");
            //        break;
            //}
        }
    }
}
