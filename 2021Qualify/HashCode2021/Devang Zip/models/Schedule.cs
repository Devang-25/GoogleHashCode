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
    public class Schedule
    {
        public Street street;
        public int time; // seconds
        public int order = int.MaxValue;

        public Schedule(Street street, int time)
        {
            this.street = street;
            this.time = time;
        }
                
    }
}
