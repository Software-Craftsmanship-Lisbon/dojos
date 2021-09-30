using System.Collections.Generic;
using Krafted.Guards;

namespace RomanNumerals
{
    public class RomanNumeral
    {
        private readonly Dictionary<int, string> _arabicToRoman = new Dictionary<int, string>
        {
            { 3000, "MMM" },
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };

        public string ToRoman(int arabic)
        {
            Guard.Against
                .ZeroOrLess(arabic, nameof(arabic))
                .GreaterThan(3000, arabic, nameof(arabic));

            var romanNumeral = string.Empty;

            foreach (var arabicKey in _arabicToRoman.Keys)
            {
                while (arabic >= arabicKey)
                {
                    romanNumeral += _arabicToRoman[arabicKey];
                    arabic -= arabicKey;
                }
            }

            return romanNumeral;
        }
    }
}
