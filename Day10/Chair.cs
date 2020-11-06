using System;
using System.Collections.Generic;
using System.Text;

namespace Day10
{
    class Chair
    {
        // Properties
        public string Material { get; set; }
        public string Color { get; set; }
        public string Usability { get; set; }
        public float Price { get; set; }
        public int Height { get; set; }

        public override string ToString()
        {
            return $"{this.Height} {this.Material} {this.Price} {this.Usability}";
        }
    }
}
