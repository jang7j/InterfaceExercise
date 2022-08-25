using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int Wheels { get; set; }
        public int Windows { get; set; }
        public int Headlights { get; set; }
        public bool Honks { get; set; }
        public void HonkNoise(); //stubbed out, no scope/inplementation
    }
}
