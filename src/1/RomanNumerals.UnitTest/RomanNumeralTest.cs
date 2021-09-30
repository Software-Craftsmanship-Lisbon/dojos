using Xunit;

namespace RomanNumerals.UnitTest
{
    public class RomanNumeralTest
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(11, "XI")]
        [InlineData(12, "XII")]
        [InlineData(13, "XIII")]
        [InlineData(14, "XIV")]
        [InlineData(15, "XV")]
        [InlineData(16, "XVI")]
        [InlineData(17, "XVII")]
        [InlineData(18, "XVIII")]
        [InlineData(19, "XIX")]
        [InlineData(20, "XX")]
        [InlineData(30, "XXX")]
        [InlineData(40, "XL")]
        [InlineData(50, "L")]
        [InlineData(60, "LX")]
        [InlineData(70, "LXX")]
        [InlineData(80, "LXXX")]
        [InlineData(90, "XC")]
        [InlineData(100, "C")]
        [InlineData(200, "CC")]
        [InlineData(300, "CCC")]
        [InlineData(400, "CD")]
        [InlineData(500, "D")]
        [InlineData(600, "DC")]
        [InlineData(700, "DCC")]
        [InlineData(800, "DCCC")]
        [InlineData(900, "CM")]
        [InlineData(1000, "M")]
        [InlineData(2000, "MM")]
        [InlineData(3000, "MMM")]
        public void ToRoman_ArabicNumber_RomanNumber(int arabic, string expected)
        {
            // Arrange
            var romanNumeral = new RomanNumeral();

            // Act
            var roman = romanNumeral.ToRoman(arabic);

            // Assert
            Assert.Equal(expected, roman);
        }
    }
}
