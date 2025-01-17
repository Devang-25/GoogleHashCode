﻿/*
Final Submission

This year, I performed Much Better than Last Year.
Hope to have Under 500 Rank Worldwide :)

"Indian Army -- SF"
Author : @Devang_25

*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static HashCode2021.Solver;

namespace HashCode2021
{
    internal static class OutputWriter
    {
        internal static string Write(string file, Result r, Rating rating)
        {
            var lines = new List<string>();

            // ================ CUSTOM OUTPUT WRITE START =========================
            // Just fill "lines" variable with each line to be outputed on file

            var placesWithSchedules = r.places.Values.Where(p => p.schedules != null && p.schedules.Count > 0).ToList();

            lines.Add(placesWithSchedules.Count.ToString());

            // 1k on C
            // .Where(s => s.order < int.MaxValue)

            foreach (var place in placesWithSchedules)
            {
                lines.Add($"{place.id}");
                lines.Add($"{place.schedules.Count()}");

                foreach (var schedule in place.schedules.Values.OrderBy(s => s.order))
                {
                    lines.Add($"{schedule.street.id} {schedule.time}");
                }
            }

            // ================ CUSTOM OUTPUT WRITE END =========================

            return Save(file, lines, rating);
        }

        private static string Save(string file, List<string> lines, Rating rating)
        {
            var path = $"../../../output/";
            var fileName = $"{path}{file}";

            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            if (rating.GetNewBest().Contains(file)) 
                File.WriteAllLines(fileName, lines);

            return fileName;
        }
    }
}