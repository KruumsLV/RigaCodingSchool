using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Day9
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car("BMW", "X5", 100000, "Black", 2016);
            Car volvo = new Car("Volvo", "asd", 100000, "Gray", 2015);
            Car ford = new Car("Ford", "123", 1564f, "Red", 2010);
            Car audi = new Car("Audi", "A6", 35000f, "Red", 2016);
            Car opel = new Car("Opel", "4", 5000f, "BLue", 2005);

            List<Car> carList = new List<Car>();
            carList.Add(volvo);
            carList.Add(bmw);
            carList.Add(ford);
            carList.Add(audi);
            carList.Add(opel);

            float maxPrice = carList.Max(car => car.Price);
            List<Car> mostExpensiveCars = carList.Where(car => car.Price == maxPrice).ToList();
            //Car[] MostExpCarsArray = carList.Where(car => car.Price == maxPrice).ToArray();
            
            foreach (Car car in mostExpensiveCars)
            {
                Console.WriteLine(car.GetString());
            }

/*           Car expensiveCar = new Car();
            foreach(Car car in carList)
            {
                if (car.Price > expensiveCar.Price)
                {
                    expensiveCar = car;
                }
            }
            Console.WriteLine(expensiveCar.GetString());*/

        }
    }
}
