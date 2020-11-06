using System;
using System.Collections.Generic;
using System.Text;

namespace Day10
{
    enum WeekDayEnum
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class ToDo
    {
        // Properties:
        // Name, Description, WeekDay, Done
        public string Name { get; set; }
        public string Description { get; set; }
        public WeekDayEnum WeekDay { get; set; }
        public bool Done { get; set; }

        // Izveidojam konstruktoru ar parametriem:
        // Name, Description, WeekDay, Done
        public ToDo(string name, string description, WeekDayEnum day, bool done)
        {
            this.Name = name;
            this.Description = description;
            this.WeekDay = day;
            this.Done = done;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Description} {this.WeekDay} {this.Done}";
        }
    }
}
