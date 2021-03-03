using AdventOfCode2020;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Runner
{
    class AOC2020Runner
    {
        static void RunDay(string dayNum)
        {
            var input = File.ReadLines($"../input/input{dayNum}.txt").ToList();
            var day = new Day02(input);
            Console.WriteLine($"Day{dayNum} A: {day.SolveA()}");  //= 1007104
            Console.WriteLine($"Day{dayNum} B: {day.SolveB()}");  //= 18847752
        }

        static void Main(string[] args)
        {
            const string DAYS_ALL = "00";

            var config = new ConfigurationBuilder()
                .AddCommandLine(args)
                .Build();

            string dayNum = (config.GetChildren().Any(i => i.Key == "day")) 
                ? config["day"].PadLeft(2, '0') 
                : DAYS_ALL;

            var days = Enumerable.Range(1, 2);

            if (dayNum == DAYS_ALL)
            {
                days.ToList().ForEach(d => RunDay(d.ToString().PadLeft(2, '0')));
            }
            else 
            {
                RunDay(dayNum);
            }
        }
    }
}
