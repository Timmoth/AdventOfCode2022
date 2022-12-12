namespace Tests
{
    public class Day12Tests
    {
        [Theory]
        [InlineData(31, "Sabqponm\r\nabcryxxl\r\naccszExk\r\nacctuvwj\r\nabdefghi")]
        public void ProcessPart1Tests(long expectedValue, string input)
        {
            //Given 
            var inputLines = input.Split("\r\n");

            //When
            var output = Day12.ProcessPart1(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }

        [Theory]
        [InlineData(29, "Sabqponm\r\nabcryxxl\r\naccszExk\r\nacctuvwj\r\nabdefghi")]
        public void ProcessPart2Tests(long expectedValue, string input)
        {
            //Given 
            var inputLines = input.Split("\r\n");

            //When
            var output = Day12.ProcessPart2(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }
    }
}