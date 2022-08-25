using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public int Length { get; set; }
        public int Weight { get; set; }
        public int Wheels { get; set; }
        public int Windows { get; set; }
        public int Headlights { get; set; }
        public bool Honks { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }

        public void HonkNoise()
        {
            Console.WriteLine("The trunk honks wah wah");
        }
    }
}
