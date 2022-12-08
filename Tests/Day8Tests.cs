namespace Tests
{
    public class Day8Tests
    {
        [Theory]
        [InlineData(21, "30373\r\n25512\r\n65332\r\n33549\r\n35390")]
        public void ProcessPart1Tests(int expectedValue, string input)
        {
            //Given 
            var inputLines = input.Split("\r\n");

            //When
            var output = Day8.ProcessPart1(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }

        [Theory]
        [InlineData(8, "30373\r\n25512\r\n65332\r\n33549\r\n35390")]
        public void ProcessPart2Tests(int expectedValue, string input)
        {
            //Given 
            var inputLines = input.Split("\r\n");

            //When
            var output = Day8.ProcessPart2(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }
    }
}