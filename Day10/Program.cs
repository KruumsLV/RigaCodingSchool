using System;
using System.Collections.Generic;
using System.Linq;

namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDo item1 = new ToDo("Dishes", "Wash the dishes", WeekDayEnum.Friday, false);
            ToDo item2 = new ToDo("Clean house", "Clean the house", WeekDayEnum.Saturday, false);
            ToDo item3 = new ToDo("Clothes", "Wash the clothes", WeekDayEnum.Thursday, true);
            ToDo item4 = new ToDo("asdasd", "asasd", WeekDayEnum.Wednesday, true);
            ToDo item5 = new ToDo("131fasf", "fawfaw", WeekDayEnum.Friday, false);

            List<ToDo> itemList = new List<ToDo>();
            itemList.Add(item1);
            itemList.Add(item2);
            itemList.Add(item3);
            itemList.Add(item4);
            itemList.Add(item5);

            // !true = false
            // !false = true
            List<ToDo> undoneItems = itemList.Where(item => !item.Done).ToList();
            Console.WriteLine("Undone items:");
            foreach(ToDo item in undoneItems)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            List<ToDo> fridayItems = itemList.Where(item => item.WeekDay == WeekDayEnum.Friday).ToList();
            Console.WriteLine("Friday items:");
            foreach (ToDo item in fridayItems)
            {
                Console.WriteLine(item);
            }

            /*            // Izveidojam Chair objektus
                        Chair chair1 = new Chair();
                        chair1.Color = "Dark blue";
                        chair1.Height = 55;
                        chair1.Material = "Wood";
                        chair1.Usability = "Kitchen";
                        chair1.Price = 30.99f;

                        Chair chair2 = new Chair();
                        chair2.Color = "Black";
                        chair2.Height = 45;
                        chair2.Material = "Wood";
                        chair2.Usability = "Living room";
                        chair2.Price = 25.99f;

                        var chairList = new List<Chair>();
                        chairList.Add(chair2);
                        chairList.Add(chair1);

                        Chair foundChair = chairList.Where(x => x.Height == 50).FirstOrDefault();
                        if (foundChair != null)
                        {
                            Console.WriteLine(foundChair);
                        }
                        else
                        {
                            Console.Write("Krēsls netika atrasts!");
                        }*/

        }
    }
}
