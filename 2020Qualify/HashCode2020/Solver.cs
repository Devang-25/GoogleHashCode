﻿using HashCode2020;
using HashCode2020.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace HashCode2021
{
    internal class Solver
    {

        public Solver()
        {
        }

        public Result Solve(Model m)
        {
            Console.WriteLine($"days: {m.days}, books: {m.books.Count}, libraries: {m.libraries.Count}");

            var bestLibraries = m.libraries.Values.OrderByDescending(l => l.maxPotentialScore).ToList();            
            var resultLibraries = new List<Library>();

            var timer = new Stopwatch();
            timer.Start();

            while(Global.RemainingDays > 0 && m.libraries.Count > 0 && timer.ElapsedMilliseconds < 1000 * 5)
            {
                bestLibraries[0].Dedup2(true);
                m.libraries.Remove(bestLibraries[0].id);
                Global.RemainingDays -= bestLibraries[0].signup;
                resultLibraries.Add(bestLibraries[0]);

                foreach (var l in m.libraries.Values) l.Dedup2(false);

                bestLibraries = m.libraries.Values.OrderByDescending(l => l.maxPotentialScore).ToList();
            }

            resultLibraries.AddRange(bestLibraries);

            return new Result(resultLibraries, m.days);
        }

        public class Result
        {
            public List<Library> libraries;
            public int days;

            public Result(List<Library> l, int days)
            {
                this.libraries = l;
                this.days = days;
            }
        }
    }
}