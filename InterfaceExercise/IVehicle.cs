using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        //In your IVehicle

        /* Create 4 members that Car, Truck, & SUV all have in common.
         * Example: All vehicles have a number of wheels... for now..
         */

        public string Make { get; set; }
        public int Doors { get; set; }
        public string Model { get; set; }
        public int MilesDriven { get; set; }

       
    }
}
