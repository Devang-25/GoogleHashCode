/*
Final Submission

This year, I performed Much Better than Last Year.
Hope to have Under 500 Rank Worldwide :)

"Indian Army -- SF"
Author : @Devang_25

*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashCode2020.models
{
    public class Light
    {
        public bool isGreen;
        public int seconds; //seconds until it turns red
        public Street street;
        public List<Car> cars; //cars currently waiting
        public Place place;

        public Light(Street street, Place place, List<Car> cars, bool isGreen, int seconds)
        {
            this.seconds = seconds;
            this.isGreen = isGreen;
            this.street = street;
            this.cars = cars;
            this.place = place;
        }       
    }
}
