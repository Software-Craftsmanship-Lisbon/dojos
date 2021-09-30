using System.Collections.Generic;
using Krafted.Guards;

namespace RomanNumerals
{
    public class ArabicNumeral
    {
        private readonly Dictionary<string, int> _romanToArabic = new Dictionary<string, int>
        {
            { "MMM", 3000 },
            { "M", 1000 },
            { "CM", 900 },
            { "D", 500 },
            { "CD", 400 },
            { "C", 100 },
            { "XC", 90 },
            { "L", 50 },
            { "XL", 40 },
            { "X", 10 },
            { "IX", 9 },
            { "V", 5 },
            { "IV", 4 },
            { "I", 1 }
        };

        public int ToArabic(string roman)
        {
            Guard.Against
                .NullOrWhiteSpace(roman, nameof(roman))
                .NotMatch(roman, "^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$", nameof(roman));

            var arabicNumeral = 0;

            while (roman.Length != 0)
            {
                foreach (var romanKey in _romanToArabic.Keys)
                {
                    if (roman.StartsWith(romanKey))
                    {
                        roman = roman.Substring(romanKey.Length);
                        arabicNumeral += _romanToArabic[romanKey];
                    }
                }
            }

            return arabicNumeral;
        }
    }
}
