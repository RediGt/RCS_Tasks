using System;

namespace RCS_08._10_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(4, "Green", "Mazda");
            Console.WriteLine(car1.Type);

            Bycicle bcc = new Bycicle();
            bcc.Drive();
        }
    }
}
