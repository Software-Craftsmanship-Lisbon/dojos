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
