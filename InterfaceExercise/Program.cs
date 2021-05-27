using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE:  TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE:  Create 2 Interfaces called IVehicle & ICompany

            //DONE:  Create 3 classes called Car , Truck , & SUV

            //DONE:  In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //DONE:  In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //DONE:  In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var car = new Car();
            var truck = new Truck();
            var suv = new SUV();

            car.CarType = "sports";
            car.CoName = "Ford";
            car.Doors = 2;
            car.Model = "Mustang";
            car.MilesDriven = 1000;
            car.IsFast = true;
            car.LocationCountry = "United States of America";

            truck.CoName = "Ford";
            truck.Model = "F150";
            truck.Doors = 4;
            truck.MilesDriven = 250000;
            truck.LocationCountry = "United States of America";
            truck.CanTow = true;
            truck.EngineType = "Gas";

            suv.CoName = "Ford";
            suv.Doors = 5;
            suv.Model = "Expedition";
            suv.LocationCountry = "United States of America";
            suv.MilesDriven = 50000;
            suv.Is4X4 = true;
            suv.NumSeats = 6;


            var carLot = new List<IVehicle>() { car, truck, suv};
            

            Console.WriteLine($"I have the following vehicles:");

            foreach (var cars in carLot)
            {
                
                   
                    Console.WriteLine($"Model:  {cars.Model}");
                    Console.WriteLine($"Miles:  {cars.MilesDriven}");
                    Console.WriteLine($"Number of doors: {cars.Doors}");
                
               
                
            }

        }
    }
}
