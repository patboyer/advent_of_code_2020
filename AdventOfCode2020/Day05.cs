using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2020
{
    public class Day05 : IDay 
    {
        private List<string> _input;
        
        public Day05(List<string> input) => (_input) = input;

        public int GetColumn(string s)
        {
            string seat = s.Substring(7, 3)
                    .ToCharArray()
                    .ToList()
                    .Select(c => (c == 'R') ? "1" : "0")
                    .Aggregate((s1, s2) => $"{s1}{s2}");

            return Convert.ToInt32(seat, 2);
        }

        public int GetRow(string s)
        {
            string seat = s.Substring(0, 7)
                    .ToCharArray()
                    .ToList()
                    .Select(c => (c == 'B') ? "1" : "0")
                    .Aggregate((s1, s2) => $"{s1}{s2}");

            return Convert.ToInt32(seat, 2);
        }

        public int GetSeatID(string s) => (8 * GetRow(s) + GetColumn(s));

        public string SolveA()
        {
            return _input.Select(s => GetSeatID(s))
                         .Max()
                         .ToString();
        }

        public string SolveB() 
        {
            var seats = _input.Select(s => GetSeatID(s))
                              .OrderBy(n => n)
                              .ToList();

            for (int idx=1; idx<seats.Count()-1; idx++)
            {
                if ((seats[idx] + 1) != seats[idx+1])
                {
                    return (seats[idx] + 1).ToString();
                }
            }

            return "";
        }
    }
}
