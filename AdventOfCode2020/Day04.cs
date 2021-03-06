using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2020
{
    public class Passport
    {
        public string BirthYear { get; set; }
        public string CountryID { get; set; }
        public string ExpirationYear { get; set; }
        public string EyeColor { get; set; }
        public string IssueYear { get; set; }
        public string HairColor { get; set; }
        public string Height { get; set; }
        public string PassportID { get; set; }

        private static string[] _validEyeColors = { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };

        public Passport()
        {
            BirthYear = CountryID = ExpirationYear = EyeColor = String.Empty;
            IssueYear = HairColor = Height = PassportID = String.Empty;
        }

        public void AddField(string s)
        {
            string[] parts = s.Split(':');
            string field = parts[0].Trim();
            string value = parts[1].Trim();

            switch(field)
            {
                case "byr": BirthYear = value; break;
                case "cid": CountryID = value; break;
                case "eyr": ExpirationYear = value; break;
                case "ecl": EyeColor = value; break;
                case "iyr": IssueYear = value; break;
                case "hcl": HairColor = value; break;
                case "hgt": Height = value; break;
                case "pid": PassportID = value; break;
            }
        }

        public bool IsValidA()
        {
            return (BirthYear != String.Empty) 
                && (ExpirationYear != String.Empty)
                && (EyeColor != String.Empty)
                && (IssueYear != String.Empty)
                && (HairColor != String.Empty)
                && (Height != String.Empty)
                && (PassportID != String.Empty);
        }

        public bool IsValidB()
        {
            return (
                IsValidBirthYear()
                && IsValidExpirationYear()
                && IsValidEyeColor()
                && IsValidIssueYear()
                && IsValidHairColor()
                && IsValidHeight()
                && IsValidPassportID()
            );
        }

        public bool IsValidBirthYear() => (BirthYear != String.Empty)
            && Regex.IsMatch(BirthYear, "^[0-9]{4}$")
            && (int.Parse(BirthYear) >= 1920)
            && (int.Parse(BirthYear) <= 2002);
        
        public bool IsValidExpirationYear() => (ExpirationYear != String.Empty)
            && Regex.IsMatch(ExpirationYear, "^[0-9]{4}$")
            && (int.Parse(ExpirationYear) >= 2020)
            && (int.Parse(ExpirationYear) <= 2030);

        public bool IsValidEyeColor() => (EyeColor != String.Empty)
            && (Array.Exists(_validEyeColors, e => e == EyeColor));

        public bool IsValidIssueYear() => (IssueYear != String.Empty)
            && Regex.IsMatch(IssueYear, "^[0-9]{4}$")
            && (int.Parse(IssueYear) >= 2010)
            && (int.Parse(IssueYear) <= 2020);

        public bool IsValidHairColor() => (HairColor != String.Empty)
            && Regex.IsMatch(HairColor, "^#[0-9a-f]{6}$");

        public bool IsValidHeight() 
        {
            if (Height == String.Empty)
            {
                return false;
            }
            else if (Regex.IsMatch(Height, "[0-9]{3}cm"))
            {
                int height = int.Parse(Height.Substring(0, 3));
                return ((height >= 150) && (height <= 193));
            }
            else if (Regex.IsMatch(Height, "^[0-9][0-9]in$"))
            {
                int height = int.Parse(Height.Substring(0, 2));
                return ((height >= 59) && (height <= 76));
            }
            else 
            {
                return false;
            }
        }

        public bool IsValidPassportID() => (PassportID != String.Empty)
            && Regex.IsMatch(PassportID, "^[0-9]{9}$");
    }

    public class Day04 : IDay 
    {
        private List<Passport> _passports;

        public Day04(List<string> input)
        {
            _passports = new List<Passport>();
            var passport = new Passport();
            
            for (int idx=0; idx<input.Count; idx++)
            {
                string line = input[idx];

                if (line == String.Empty)
                {
                    _passports.Add(passport);
                    passport = new Passport();
                }
                else 
                {
                    line.Split(' ')
                        .ToList()
                        .ForEach(s => passport.AddField(s));
                }
            }

            _passports.Add(passport);
        }

        public string SolveA()
        {
            return _passports.Where(p => p.IsValidA()).Count().ToString();
        }

        public string SolveB() 
        {
            return _passports.Where(p => p.IsValidB()).Count().ToString();
        }
    }
}
