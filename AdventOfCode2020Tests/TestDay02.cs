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
        public void TestIsValidPasswordA()
        {
            Assert.True(_day.IsValidPasswordA("1-3 a: abcde"));
            Assert.False(_day.IsValidPasswordA("1-3 b: cdefg"));
            Assert.True(_day.IsValidPasswordA("2-9 c: ccccccccc"));
            Assert.True(_day.IsValidPasswordA("2-9 c: cacacacacacacacac"));
        }

        [Fact]
        public void TestIsValidPasswordB()
        {
            Assert.True(_day.IsValidPasswordB("1-3 a: abcde"));
            Assert.False(_day.IsValidPasswordB("1-3 b: cdefg"));
            Assert.False(_day.IsValidPasswordB("2-9 c: ccccccccc"));
            Assert.True(_day.IsValidPasswordB("2-9 c: cacacacacacacacac"));
        }

        [Fact]
        public void TestSolveA()
        {
            Assert.Equal("2", _day.SolveA());
        }

        [Fact]
        public void TestSolveB()
        {
            Assert.Equal("1", _day.SolveB());
        }
    }
}
