using Xunit;

namespace RomanNumerals.UnitTest
{
    public class ArabicNumeralTest
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        [InlineData("VII", 7)]
        [InlineData("VIII", 8)]
        [InlineData("IX", 9)]
        [InlineData("X", 10)]
        [InlineData("XI", 11)]
        [InlineData("XII", 12)]
        [InlineData("XIII", 13)]
        [InlineData("XIV", 14)]
        [InlineData("XV", 15)]
        [InlineData("XVI", 16)]
        [InlineData("XVII", 17)]
        [InlineData("XVIII", 18)]
        [InlineData("XIX", 19)]
        [InlineData("XX", 20)]
        [InlineData("XXX", 30)]
        [InlineData("XL", 40)]
        [InlineData("L", 50)]
        [InlineData("LX", 60)]
        [InlineData("LXX", 70)]
        [InlineData("LXXX", 80)]
        [InlineData("XC", 90)]
        [InlineData("C", 100)]
        [InlineData("CC", 200)]
        [InlineData("CCC", 300)]
        [InlineData("CD", 400)]
        [InlineData("D", 500)]
        [InlineData("DC", 600)]
        [InlineData("DCC", 700)]
        [InlineData("DCCC", 800)]
        [InlineData("CM", 900)]
        [InlineData("M", 1000)]
        [InlineData("MM", 2000)]
        [InlineData("MMM", 3000)]
        public void ToArabic_RomanNumber_ArabicNumber(string roman, int expected)
        {
            // Arrange
            var arabicNumeral = new ArabicNumeral();

            // Act
            var arabic = arabicNumeral.ToArabic(roman);

            // Assert
            Assert.Equal(expected, arabic);
        }
    }
}
