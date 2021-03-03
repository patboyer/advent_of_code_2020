using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2020
{
    public class Day02
    {
        private List<string> _input;

        public Day02(List<string> input) => _input = input;

        private bool IsValidPassword(string s) 
        {
            string[] parts = s.Split(new Char[] { '-', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = $"{parts[2]}{{{parts[0]},{parts[1]}}}";
            return Regex.IsMatch(parts[3], pattern);
        }

        public int SolveA() 
        {
            return _input.Where(s => IsValidPassword(s)).Count();
        }

        public int SolveB()
        {
            return -1;
        }
    }
}
