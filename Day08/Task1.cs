using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Day8
{
    class Task1
    {
        public static int[] GetOnlySmallValues(int[] intArray)
        {
            return intArray.Where(num => num < 5).ToArray();
            /*List<int> list = new List<int>();
            foreach(int num in intArray)
            {
                if (num < 5)
                {
                    list.Add(num);
                }
            }

            return list.ToArray();*/
        }
    }
}
