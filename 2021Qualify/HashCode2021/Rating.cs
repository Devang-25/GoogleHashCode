﻿using HashCode2020.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using static HashCode2021.Solver;

namespace HashCode2021
{
    internal class Rating
    {
        private Dictionary<string, (int score, bool best)> ratings = new Dictionary<string, (int, bool)>();
        private string PATH = "../../../ratings.txt";

        public Rating(HashSet<string> files)
        {
            if (!File.Exists(PATH))
            {
                File.WriteAllLines(PATH, files.Select(f => $"{f} -1").ToArray());
            }

            var lines = File.ReadAllLines(PATH);

            foreach(var line in lines)
            {
                var (file, score) = line.Split2<string,int>(" ");
                ratings[file] = (score, false);
            }
        }

        internal int Calculate(string file, Result r)
        {
            // ================ CUSTOM SCORE CALCULATION START =========================
            // Just fill score variable
            
            var score = 0;


            // Log info about the result
            L.Log($"any insight about the score...(duplicates, unused)");
            // ================ CUSTOM SCORE CALCULATION END =========================

            Print(file, score);
            Save(file, score);
            return score;
        }

        private void Print(string file, int score)
        {
            char symbol = '=';
            var color = ConsoleColor.DarkGray;
            if (score > ratings[file].score) { symbol = '+'; color = ConsoleColor.Green; }
            else if (score < ratings[file].score) { symbol = '-'; color = ConsoleColor.Red; }

            var msg = $"{file}: {score} ([{symbol}{Math.Abs(score - ratings[file].score)}])";
            Utils.AddSummary(msg, color);
            Utils.AddTotal(score);
        }
                
        private void Save(string file, int score) 
        {
            if (score > ratings[file].score)
            {
                ratings[file] = (score, true);
                File.WriteAllLines(PATH, ratings.Select(r => $"{r.Key} {r.Value.score}").ToArray());
            }            
        }

        public HashSet<string> GetNewBest()
        {
            return ratings.Where(r => r.Value.best).Select(r => r.Key).ToHashSet();
        }
    }
}