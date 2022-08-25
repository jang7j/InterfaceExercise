using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
     
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            Car car = new Car(); //IVehicle car = new Car(); also works because IVehicle CONFORMS to Car
            Truck truck = new Truck();
            SUV suv = new SUV();

            var list = new List<IVehicle> { car, truck, suv }; //Just like: List<int> = new List<int> {1, 2, 3};

            //object initializer syntax
            var camry = new Car() { HasTrunk = true, IsConvertible = false, Wheels = 4, Windows = 4, Headlights = 2, Honks = true, Logo = "Oval inside an oval", Name = "private" };

            //dot notation
            var oilTanker = new Truck();
            oilTanker.Logo = "Shell";
            oilTanker.Length = 60;
            oilTanker.Weight = 60000;

            //custom constuctor
            
            SUV nissan = new SUV(6, true); //Go to SUV class first, then declare public SUV 
            

            camry.HonkNoise();
            oilTanker.HonkNoise();
            nissan.HonkNoise();
            Console.WriteLine("==========================");
            Console.WriteLine($"My Camry has the following attributes: \n \n \n" +
                $"Trunk: {camry.HasTrunk}, \n \n" +
                $"Convertible: {camry.IsConvertible}, \n \n" +
                $"Wheels: {camry.Wheels}, \n \n" +
                $"Windows: {camry.Windows}, \n \n" +
                $"Headlights: {camry.Headlights}, \n \n" +
                $"Honks: {camry.Honks}, \n \n" +
                $"Logo: {camry.Logo}, \n \n" +
                $"Company: {camry.Name}\n\n") ;
        }
    }
}
