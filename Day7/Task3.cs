using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class Task3
    {
        public static void PrintArrayValues(string[] array)
        {
            foreach(string item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        public static void PrintArrayValues(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
