using System;
using System.Collections.Generic;
using System.Text;

namespace RCS_08._10_Tasks
{
    class Bycicle: Vehicle
    {
        public int Wheels { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }

        public Bycicle()
        {
        }

        public Bycicle(int wls, string clr, string tp)
        {
            this.Wheels = wls;
            this.Color = clr;
            this.Type = tp;
        }

        public new void Drive()
        {
            Console.WriteLine("Bycicle has no engine");
        }
    }
}
