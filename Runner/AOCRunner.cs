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
            var input = File.ReadLines($"../input/input{dayNum}.txt")
                .Select(s => s.Trim())
                .ToList();

            IDay day = dayNum switch
            {
                "01" => new Day01(input),
                "02" => new Day02(input),
                "03" => new Day03(input),
                "04" => new Day04(input),
                "05" => new Day05(input),
                "06" => new Day06(input),
            };

            Console.WriteLine($"Day{dayNum} A: {day.SolveA()}");  
            Console.WriteLine($"Day{dayNum} B: {day.SolveB()}"); 
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

            if (dayNum == DAYS_ALL)
            {
                Enumerable.Range(1, 3)
                          .ToList()
                          .ForEach(d => RunDay(d.ToString().PadLeft(2, '0')));
            }
            else 
            {
                RunDay(dayNum);
            }             
        }
    }
}
