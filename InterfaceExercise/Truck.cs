using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany

    {
        //In each of your car, truck, and suv classes

        /*Create 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         * 
         */

        public bool CanTow { get; set; }
        public string EngineType { get; set; }

        public int NumSeats { get; set; }
        public bool Is4X4 { get; set; }
        public string Make { get; set; }
        public int Doors { get; set; }
        public string Model { get; set; }
        public int MilesDriven { get; set; }
        public string CoName { get; set; }
        public string LocationCountry { get; set; }
    }
}
