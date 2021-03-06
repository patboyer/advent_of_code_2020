using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2020
{
    public class Day03 : IDay 
    {
        private List<string> _input;
        private const char TILE_TREE  = '#';
        private const char TILE_SPACE = ' ';

        public Day03(List<string> input) => _input = input;

        public long Solve(int xmove, int ymove)
        {
            (int x, int y) p = (0, 0);
            long numTrees = 0;
            int xmax = _input[0].Length;
            int ymax = _input.Count;

            while (p.y < ymax)
            {
                if (_input[p.y][p.x] == TILE_TREE)
                    numTrees++;
                
                p.x = (p.x + xmove) % xmax;
                p.y += ymove;
            }

            return numTrees;
        }

        public string SolveA()
        {
            return Solve(3, 1).ToString();
        }

        public string SolveB() 
        {
            long result = Solve(1, 1)
                 * Solve(3, 1)
                 * Solve(5, 1)
                 * Solve(7, 1)
                 * Solve(1, 2);
            
            return result.ToString();
        }
    }
}
