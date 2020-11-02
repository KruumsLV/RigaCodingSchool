using System;
using System.Collections.Generic;
using System.Linq;

namespace Day7
{
    class Program
    {
        private static int Sum(int a, int b)
        {
            if (a > b)
            {
                return a + b;
            }

            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(3, 2));
        }
    }
}
