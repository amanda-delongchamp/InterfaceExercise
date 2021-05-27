using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface ICompany
    {
        //In ICompany

        /*Create 2 members that are specific to each every company
         * regardless of vehicle type.
         *
         *
         * Example: public string Logo { get; set; }
         */

        public string CoName { get; set; }
        public string LocationCountry { get; set; }
    }
}
