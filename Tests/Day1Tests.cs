namespace Tests
{
    public class Day1Tests
    {
        [Theory]
        [InlineData(10, "10")]
        [InlineData(30, "10", "20")]
        [InlineData(20, "10", "", "20")]
        [InlineData(60, "10", "", "40", "20", "", "30")]
        [InlineData(24000, "1000", "2000", "3000", "", "4000", "", "5000", "6000", "", "7000", "8000", "9000", "", "10000")]
        public void ProcessReturnsTheMostCaloriesCarriedByOneElf(int expectedValue, params string[] input)
        {
            //Given 
            var inputLines = input.ToArray();

            //When
            var output = Day1.ProcessPart1(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }

        [Theory]
        [InlineData(10, "10")]
        [InlineData(20, "10", "", "10")]
        [InlineData(30, "10", "", "10", "", "10")]
        [InlineData(30, "10", "", "10", "", "10", "", "10")]
        [InlineData(45000, "1000", "2000", "3000", "", "4000", "", "5000", "6000", "", "7000", "8000", "9000", "", "10000")]
        public void ProcessReturnsTheMostCaloriesCarriedByThreeElfs(int expectedValue, params string[] input)
        {
            //Given 
            var inputLines = input.ToArray();

            //When
            var output = Day1.ProcessPart2(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }
    }
}