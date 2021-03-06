using System;
using System.Linq;
using System.Collections.Generic;

namespace AdventOfCode2020
{
    public class Day01 : IDay 
    {
        private List<int> _input;

        public Day01(List<string> input)
        {
            _input = input.Select(s => int.Parse(s)).ToList();
        }

        public string SolveA() 
        {
            return _input 
                .SelectMany(x => _input, (x, y) => (x, y))
                .Where(t => (t.x + t.y) == 2020)
                .Select(t => t.x * t.y)
                .First()
                .ToString();
        }

        public string SolveB()
        {
            return _input 
                .SelectMany(x => _input, (x, y) => (x, y))
                .SelectMany(t => _input, (t, z) => (t.x, t.y, z))
                .Where(t => (t.x + t.y + t.z) == 2020)
                .Select(t => t.x * t.y * t.z)
                .First()
                .ToString();
        }
    }
}
