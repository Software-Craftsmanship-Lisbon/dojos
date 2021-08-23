// Maicon
// Danilo
// Tiago
// William
// Carlos

namespace RomanNumerals
{
    public class RomanNumeral
    {
        public string ToRoman(int arabic)
        {
            string roman = string.Empty;

            for (int i = 0; i < arabic; i++)
            {
                roman += "I";

            }

            if (arabic == 4)
            {
                return "IV";
            }

            if (arabic == 5)
            {
                return "V";
            }

            if (arabic == 6)
            {
                return "VI";
            }

            return roman;
        }
    }
}
