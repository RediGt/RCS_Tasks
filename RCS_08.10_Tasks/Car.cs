using System;
using System.Collections.Generic;
using System.Text;

namespace RCS_08._10_Tasks
{
    class Car: Vehicle
    {
        public int Wheels { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }

        public Car()
        {
        }

        public Car(int wls, string clr, string tp)
        {
            this.Wheels = wls;
            this.Color = clr;
            this.Type = tp;
        }
    }
}
