using System;
using System.Linq;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] intArray = { 3, 6, 5, 4, -5, 1, 10 };
            Console.WriteLine(String.Join(",", intArray));
            Console.WriteLine(String.Join(",", Task1.GetOnlySmallValues(intArray)));
            Console.WriteLine(String.Join(",", intArray));*/

            Console.WriteLine(PasswordValidator.ValidatePassword("1234"));
            Console.WriteLine(PasswordValidator.ValidatePassword("12345678"));
            Console.WriteLine(PasswordValidator.ValidatePassword("12A34789"));
        }
    }
}
