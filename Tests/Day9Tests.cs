namespace Tests
{
    public class Day9Tests
    {
        [Theory]
        [InlineData(13, "R 4\r\nU 4\r\nL 3\r\nD 1\r\nR 4\r\nD 1\r\nL 5\r\nR 2")]
        public void ProcessPart1Tests(int expectedValue, string input)
        {
            //Given 
            var inputLines = input.Split("\r\n");

            //When
            var output = Day9.ProcessPart1(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }

        [Theory]
        [InlineData(36, "R 5\r\nU 8\r\nL 8\r\nD 3\r\nR 17\r\nD 10\r\nL 25\r\nU 20")]
        public void ProcessPart2Tests(int expectedValue, string input)
        {
            //Given 
            var inputLines = input.Split("\r\n");

            //When
            var output = Day9.ProcessPart2(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }
    }
}