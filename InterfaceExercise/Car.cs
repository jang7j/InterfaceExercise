using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public bool HasTrunk { get; set; }
        public bool IsConvertible { get; set; }
        public int Wheels { get ; set ; }
        public int Windows { get; set; }
        public int Headlights { get; set; }
        public bool Honks { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }

        public void HonkNoise()
        {
            Console.WriteLine("My car honks beep beep");
        }
    }
}
