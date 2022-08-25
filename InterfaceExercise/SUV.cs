using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public SUV() //1. Generate constructor for custom constructor
        {
        }

        public SUV(int numberOfPassengers, bool hasSlidingDoors) //2. Custom constructor
        {
            NumberOfPassengers = numberOfPassengers;
            HasSlidingDoors = hasSlidingDoors;
        }
        public int NumberOfPassengers { get; set; }
        public bool HasSlidingDoors { get; set; }
        public int Wheels { get; set; } = 4; //setting defaults
        public int Windows { get; set; } = 6;
        public int Headlights { get; set; } = 2;
        public bool Honks { get; set; }
        public string Logo { get; set; }
        public string TypeOfInstitution { get; set; }
        public string Name { get; set; }

        public void HonkNoise()
        {
            Console.WriteLine("The SUV honks pang pang");
        }
    }
}
