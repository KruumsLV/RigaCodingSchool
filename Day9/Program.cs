using System;
using System.Collections.Generic;

namespace Day9
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car("BMW", "X5", 50000f, "Black", 2016);
            Car volvo = new Car("Volvo", "asd", 20000f, "Gray", 2015);

            List<Car> carList = new List<Car>();
            carList.Add(bmw);
            carList.Add(volvo);

            Car expensiveCar = new Car();
            foreach(Car car in carList)
            {
                if (car.Price > expensiveCar.Price)
                {
                    expensiveCar = car;
                }
            }
            Console.WriteLine(expensiveCar.GetString());

        }
    }
}
