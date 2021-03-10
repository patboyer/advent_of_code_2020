using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCode2020
{
    public class Day06 : IDay 
    {
        private List<string> _groups;
        private List<int> _numPeople;
        
        public Day06(List<string> input) 
        {
            _groups = new List<string>();
            _numPeople = new List<int>();
            var group = new StringBuilder("");
            int numPeople = 0;
            
            foreach (string line in input)
            {
                if (line == "")
                {
                    _groups.Add(group.ToString());
                    _numPeople.Add(numPeople);
                    group = new StringBuilder("");
                    numPeople = 0;
                }
                else 
                {
                    group.Append(line.ToLower());
                    numPeople++;
                }
            }

            _groups.Add(group.ToString());
            _numPeople.Add(numPeople);
        }

        public int GetNumYes(string s)
        {
            return s.ToCharArray().Distinct().Count();
        }

        public int GetNumEveryoneYes(string s, int target)
        {
            var dict = new Dictionary<char, int>();

            foreach (char c in s.ToCharArray())
            {
                if (dict.ContainsKey(c))
                    dict[c] += 1;
                else 
                    dict.Add(c, 1);
            }

            return dict.Values.Where(n => (n == target)).Count();
        }

        public string SolveA()
        {
            return _groups.Select(g => GetNumYes(g))
                          .Sum()
                          .ToString();
        }

        public string SolveB() 
        {
            int result = 0;

            for (int idx=0; idx<_groups.Count; idx++)
            {
                result += GetNumEveryoneYes(_groups[idx], _numPeople[idx]);
            }

            return result.ToString();
        }
    }
}
