using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Task2
    {
        public static void PrintMyName(string name, string surname)
        {
            Console.WriteLine($"{ name.Substring(0, 1).ToUpper() }. {surname}");
        }
    }
}
