using System;

namespace Day9
{
    class Car
    {
        // definēt klases laukus (attribute)
        private string make;
        private string model;
        private float price;
        private string color;
        private int year;

        // Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public float Price { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public Car() { }

        public Car(string make, string model, float price, string color, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.Color = color;
            this.Year = year;
        }
        // public string GetString()...
        public string GetString()
        {
            return $"{this.Make}, {this.Model}, {this.Price:0.##}, {this.Color}, {this.Year}";
        }
    }
}
