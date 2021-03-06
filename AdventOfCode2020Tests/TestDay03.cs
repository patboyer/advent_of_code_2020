using AdventOfCode2020;
using System;
using System.Collections.Generic;
using Xunit;

namespace AdventOfCode2020Tests
{
    public class TestDay03
    {
        private Day03 _day;

        public TestDay03()
        {
            List<string> input = new List<string>() { 
                "..##.......",
                "#...#...#..",
                ".#....#..#.",
                "..#.#...#.#",
                ".#...##..#.",
                "..#.##.....",
                ".#.#.#....#",
                ".#........#",
                "#.##...#...",
                "#...##....#",
                ".#..#...#.#"
            };

            _day = new Day03(input);
        }

        [Fact]
        public void TestSolve()
        {
            Assert.Equal(2, _day.Solve(1, 1));
            Assert.Equal(7, _day.Solve(3, 1));
            Assert.Equal(3, _day.Solve(5, 1));
            Assert.Equal(4, _day.Solve(7, 1));
            Assert.Equal(2, _day.Solve(1, 2));
        }

        [Fact]
        public void TestSolveA()
        {
            Assert.Equal("7", _day.SolveA());
        }

        [Fact]
        public void TestSolveB()
        {
            Assert.Equal("336", _day.SolveB());
        }
    }
}
