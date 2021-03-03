using AdventOfCode2020;
using System;
using System.Collections.Generic;
using Xunit;

namespace AdventOfCode2020Tests
{
    public class TestDay02
    {
        private Day02 _day;

        public TestDay02()
        {
            List<string> input = new List<string>() { 
                "1-3 a: abcde",
                "1-3 b: cdefg",
                "2-9 c: ccccccccc",
            };

            _day = new Day02(input);
        }

        [Fact]
        public void TestSolveA()
        {
            int result = _day.SolveA();
            Assert.Equal(2, result);
        }

        [Fact]
        public void TestSolveB()
        {
            int result = _day.SolveB();
            Assert.Equal(0, result);
        }
    }
}
