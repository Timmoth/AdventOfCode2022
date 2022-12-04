namespace Tests
{
    public class Day2Tests
    {
        [Theory]
        [InlineData(4, "A X")]
        [InlineData(8, "A Y")]
        [InlineData(3, "A Z")]
        [InlineData(1, "B X")]
        [InlineData(5, "B Y")]
        [InlineData(9, "B Z")]
        [InlineData(7, "C X")]
        [InlineData(2, "C Y")]
        [InlineData(6, "C Z")]
        [InlineData(10, "A X", "C Z")]
        public void CalculateScoreReturnsTotalScore(int expectedValue, params string[] input)
        {
            //Given 
            var inputLines = input.ToArray();

            //When
            var output = Day2.CalculateScore(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }
    }
}