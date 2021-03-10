using AdventOfCode2020;
using System.Collections.Generic;
using Xunit;

namespace AdventOfCode2020Tests
{
    public class TestDay05
    {
        private Day05 _day;

        public TestDay05()
        {
            List<string> input = new List<string>() { 
                "FBFBBFFRLR",
                "BFFFBBFRRR",
                "FFFBBBFRRR",
                "BBFFBBFRLL"
            };

            _day = new Day05(input);
        }

        [Fact]
        public void TestGetRow()
        {
            Assert.Equal( 44, _day.GetRow("FBFBBFFRLR"));
            Assert.Equal( 70, _day.GetRow("BFFFBBFRRR"));
            Assert.Equal( 14, _day.GetRow("FFFBBBFRRR"));
            Assert.Equal(102, _day.GetRow("BBFFBBFRLL"));
        }

        [Fact]
        public void TestGetColumn()
        {
            Assert.Equal(5, _day.GetColumn("FBFBBFFRLR"));
            Assert.Equal(7, _day.GetColumn("BFFFBBFRRR"));
            Assert.Equal(7, _day.GetColumn("FFFBBBFRRR"));
            Assert.Equal(4, _day.GetColumn("BBFFBBFRLL"));
        }

        [Fact]
        public void TestGetSeatID()
        {
            Assert.Equal(357, _day.GetSeatID("FBFBBFFRLR"));
            Assert.Equal(567, _day.GetSeatID("BFFFBBFRRR"));
            Assert.Equal(119, _day.GetSeatID("FFFBBBFRRR"));
            Assert.Equal(820, _day.GetSeatID("BBFFBBFRLL"));
        }

        [Fact]
        public void TestSolveA()
        {
            Assert.Equal("820", _day.SolveA());
        }
    }
}
