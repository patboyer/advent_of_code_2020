using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2020
{
    public class Day02 : IDay
    {
        private List<string> _input;

        public Day02(List<string> input) => _input = input;

        public bool IsValidPasswordA(string s) 
        {
            string[] parts = s.Split(new Char[] { '-', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int policyMin = int.Parse(parts[0]);
            int policyMax = int.Parse(parts[1]);
            string letter = parts[2];
            string password = parts[3];
            int numMatches = Regex.Matches(password, letter).Count;
            return ( (numMatches >= policyMin) && (numMatches <= policyMax) );
        }

        public bool IsValidPasswordB(string s) 
        {
            string[] parts = s.Split(new Char[] { '-', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int idx1 = int.Parse(parts[0]) - 1;
            int idx2 = int.Parse(parts[1]) - 1;
            char letter = parts[2][0];
            string password = parts[3];

            return ( 
                (idx1 < password.Length)
                && (idx2 < password.Length)
                && (password[idx1] == letter) ^ (password[idx2] == letter) 
            );
        }

        public string SolveA() 
        {
            return _input.Where(s => IsValidPasswordA(s)).Count().ToString();
        }

        public string SolveB()
        {
            return _input.Where(s => IsValidPasswordB(s)).Count().ToString();
        }
    }
}
