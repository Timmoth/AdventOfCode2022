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
        [InlineData(15, "A Y", "B X", "C Z")]
        public void ProcessReturnsTotalScoreForPart1(int expectedValue, params string[] input)
        {
            //Given 
            var inputLines = input.ToArray();

            //When
            var output = Day2.ProcessPart1(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }

          [Theory]
          [InlineData(3, "A X")]
          [InlineData(4, "A Y")]
          [InlineData(8, "A Z")]
          [InlineData(1, "B X")]
          [InlineData(5, "B Y")]
          [InlineData(9, "B Z")]
          [InlineData(2, "C X")]
          [InlineData(6, "C Y")]
          [InlineData(7, "C Z")]
          [InlineData(12, "A Y", "B X", "C Z")]
        public void ProcessReturnsTotalScoreForPart2(int expectedValue, params string[] input)
        {
            //Given 
            var inputLines = input.ToArray();

            //When
            var output = Day2.ProcessPart2(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }
    }
}