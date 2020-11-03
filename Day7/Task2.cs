using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class Task2
    {
        public static void PrintNameSurname(string nameSurname)
        {
            Console.WriteLine(nameSurname);
        }
        public static void PrintNameSurname(string name, string surname)
        {
            Console.WriteLine($"{name} {surname}");
        }
        public static void PrintNameAge(string name, int age = 99) 
        {
            Console.WriteLine($"Vārds: {name} Vecums: {age}");
        }
    }
}
