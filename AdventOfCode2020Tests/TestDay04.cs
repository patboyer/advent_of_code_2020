using AdventOfCode2020;
using System;
using System.Collections.Generic;
using Xunit;

namespace AdventOfCode2020Tests
{
    public class TestDay04
    {
        private Day04 _day;
        private Passport _passport;

        public TestDay04()
        {
            List<string> input = new List<string>() { 
                "eyr:1972 cid:100",
                "hcl:#18171d ecl:amb hgt:170 pid:186cm iyr:2018 byr:1926",
                "",
                "iyr:2019",
                "hcl:#602927 eyr:1967 hgt:170cm",
                "ecl:grn pid:012533040 byr:1946",
                "",
                "hcl:dab227 iyr:2012",
                "ecl:brn hgt:182cm pid:021572410 eyr:2020 byr:1992 cid:277",
                "",
                "hgt:59cm ecl:zzz",
                "eyr:2038 hcl:74454a iyr:2023",
                "pid:3556412378 byr:2007",
                "",
                "pid:087499704 hgt:74in ecl:grn iyr:2012 eyr:2030 byr:1980",
                "hcl:#623a2f",
                "",
                "eyr:2029 ecl:blu cid:129 byr:1989",
                "iyr:2014 pid:896056539 hcl:#a97842 hgt:165cm",
                "",
                "hcl:#888785",
                "hgt:164cm byr:2001 iyr:2015 cid:88",
                "pid:545766238 ecl:hzl",
                "eyr:2022",
                "",
                "iyr:2010 hgt:158cm hcl:#b6652a ecl:blu byr:1944 eyr:2021 pid:093154719"
            };

            _day = new Day04(input);
            _passport = new Passport();
        }

        [Fact]
        public void TestPassportAddField()
        {
            _passport.AddField("byr:1937");
            Assert.Equal("1937", _passport.BirthYear);
            _passport.AddField("cid:147");
            Assert.Equal("147", _passport.CountryID);
            _passport.AddField("eyr:2020");
            Assert.Equal("2020", _passport.ExpirationYear);
            _passport.AddField("ecl:gry");
            Assert.Equal("gry", _passport.EyeColor);
            _passport.AddField("hcl:#fffffd");
            Assert.Equal("#fffffd", _passport.HairColor);
            _passport.AddField("hgt:183cm");
            Assert.Equal("183cm", _passport.Height);
            _passport.AddField("iyr:2013");
            Assert.Equal("2013", _passport.IssueYear);
            _passport.AddField("pid:860033327");
            Assert.Equal("860033327", _passport.PassportID);
        }

        [Fact]
        public void TestPassportValidA()
        {
            _passport.AddField("byr:1937");
            _passport.AddField("cid:147");
            _passport.AddField("eyr:2020");
            _passport.AddField("ecl:gry");
            _passport.AddField("hcl:#fffffd");
            _passport.AddField("hgt:183cm");
            _passport.AddField("iyr:2013");
            _passport.AddField("pid:860033327");

            Assert.True(_passport.IsValidA());
            _passport.CountryID = String.Empty;
            Assert.True(_passport.IsValidA());
            _passport.Height = String.Empty;
            Assert.False(_passport.IsValidA());
        }

        [Fact]
        public void TestIsValidBirthYear()
        {
            _passport.AddField("byr:2002");
            Assert.True(_passport.IsValidBirthYear());
            _passport.AddField("byr:2003");
            Assert.False(_passport.IsValidBirthYear());
        }

        [Fact]
        public void TestIsValidEyeColor()
        {
            _passport.AddField("ecl:brn");
            Assert.True(_passport.IsValidEyeColor());
            _passport.AddField("ecl:wat");
            Assert.False(_passport.IsValidEyeColor());
        }

        [Fact]
        public void TestIsValidHairColor()
        {
            _passport.AddField("hcl:#123abc");
            Assert.True(_passport.IsValidHairColor());
            _passport.AddField("hcl:#123abz");
            Assert.False(_passport.IsValidHairColor());
            _passport.AddField("hcl:123abc");
            Assert.False(_passport.IsValidHairColor());
        }

        [Fact]
        public void TestIsValidHeight()
        {
            _passport.AddField("hgt:60in");
            Assert.True(_passport.IsValidHeight());
            _passport.AddField("hgt:190cm");
            Assert.True(_passport.IsValidHeight());
            _passport.AddField("hgt:190in");
            Assert.False(_passport.IsValidHeight());
            _passport.AddField("hgt:190");
            Assert.False(_passport.IsValidHeight());
        }

        [Fact]
        public void TestIsValidPassportID()
        {
            _passport.AddField("pid:000000001");
            Assert.True(_passport.IsValidPassportID());
            _passport.AddField("pid:0123456789");
            Assert.False(_passport.IsValidPassportID());
        }

        [Fact]
        public void TestSolveA()
        {
            Assert.Equal("8", _day.SolveA());
        }

        [Fact]
        public void TestSolveB()
        {
            Assert.Equal("4", _day.SolveB());
        }
    }
}
