using AdventOfCode2020;
using System.Collections.Generic;
using Xunit;

namespace AdventOfCode2020Tests
{
    public class TestDay06
    {
        private Day06 _day;

        public TestDay06()
        {
            List<string> input = new List<string>() { 
                "abc",
                "",
                "a",
                "b",
                "c",
                "",
                "ab",
                "ac",
                "",
                "a",
                "a",
                "a",
                "a",
                "",
                "b"
            };

            _day = new Day06(input);
        }

        [Fact]
        public void TestGetNumYes()
        {
            Assert.Equal(3, _day.GetNumYes("abc"));
            Assert.Equal(3, _day.GetNumYes("abac"));
            Assert.Equal(1, _day.GetNumYes("aaaaa"));
            Assert.Equal(1, _day.GetNumYes("b"));
        }

        [Fact]
        public void TestGetNumEveryoneYes()
        {
            Assert.Equal(3, _day.GetNumEveryoneYes("abc", 1));
            Assert.Equal(0, _day.GetNumEveryoneYes("abc", 3));
            Assert.Equal(1, _day.GetNumEveryoneYes("abac", 2));
            Assert.Equal(1, _day.GetNumEveryoneYes("aaaa", 4));
            Assert.Equal(1, _day.GetNumEveryoneYes("b", 1));
        }

        [Fact]
        public void TestSolveA()
        {
            Assert.Equal("11", _day.SolveA());
        }

        [Fact]
        public void TestSolveB()
        {
            Assert.Equal("6", _day.SolveB());
        }
    }
}
