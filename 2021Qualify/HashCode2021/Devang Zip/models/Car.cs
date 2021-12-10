/*
Final Submission

This year, I performed Much Better than Last Year.
Hope to have Under 500 Rank Worldwide :)

"Indian Army -- SF"
Author : @Devang_25

*/




using System;
using System.Collections.Generic;
using System.Text;

namespace HashCode2020.models
{
    public class Car
    {
        public int id;
        public List<Street> route = new List<Street>();
        public double score = 0;

        // used by score
        public int curstreetindex = 0; // index of current street where the car is in its route

        public Car(int id)
        {            
            this.id = id;
        }
    }
}
