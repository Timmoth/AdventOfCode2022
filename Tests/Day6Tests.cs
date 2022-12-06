namespace Tests
{
    public class Day6Tests
    {
        [Theory]
        [InlineData(5, "bvwbjplbgvbhsrlpgdmjqwftvncz")]
        [InlineData(6, "nppdvjthqldpwncqszvftbrmjlhg")]
        [InlineData(10, "nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg")]
        [InlineData(11, "zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw")]
        public void ProcessReturnsFirstStartOfPacket(int expectedValue, string input)
        {
            //Given 
            //When
            var output = Day6.ProcessPart1(input);

            //Then
            Assert.Equal(expectedValue, output);
        }

        [Theory]
        [InlineData(19, "mjqjpqmgbljsphdztnvjfqwrcgsmlb")]
        [InlineData(23, "bvwbjplbgvbhsrlpgdmjqwftvncz")]
        [InlineData(23, "nppdvjthqldpwncqszvftbrmjlhg")]
        [InlineData(29, "nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg")]
        [InlineData(26, "zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw")]
        public void ProcessReturnsFirstStartOfMessage(int expectedValue, string input)
        {
            //Given 
            //When
            var output = Day6.ProcessPart2(input);

            //Then
            Assert.Equal(expectedValue, output);
        }
    }
}