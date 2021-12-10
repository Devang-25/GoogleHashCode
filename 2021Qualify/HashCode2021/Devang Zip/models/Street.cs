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
    public class Street
    {
        public string id;
        public int cost;
        public int origin;
        public int dest;
        public double countCarsPassingBy = 0;
        public double countScore = 0;

        public Street(string id, int cost, int origin, int dest)
        {
            this.id = id;
            this.cost = cost;
            this.origin = origin;
            this.dest = dest;
        }
                
    }
}
