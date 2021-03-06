using AdventOfCode2020;
using System;
using System.Collections.Generic;
using Xunit;

namespace AdventOfCode2020Tests
{
    public class TestDay01
    {
        private Day01 _day;

        public TestDay01()
        {
            List<string> input = new List<string>() { "1721", "979", "366", "299", "675", "1456" };
            _day = new Day01(input);
        }

        [Fact]
        public void TestSolveA()
        {
            Assert.Equal("514579", _day.SolveA());
        }

        [Fact]
        public void TestSolveB()
        {
            Assert.Equal("241861950", _day.SolveB());
        }
    }
}
