using Xunit.Abstractions;

namespace Tests
{
    public class Day13Tests
    {
        [Theory]
        [InlineData(13, "[1,1,3,1,1]\r\n[1,1,5,1,1]\r\n\r\n[[1],[2,3,4]]\r\n[[1],4]\r\n\r\n[9]\r\n[[8,7,6]]\r\n\r\n[[4,4],4,4]\r\n[[4,4],4,4,4]\r\n\r\n[7,7,7,7]\r\n[7,7,7]\r\n\r\n[]\r\n[3]\r\n\r\n[[[]]]\r\n[[]]\r\n\r\n[1,[2,[3,[4,[5,6,7]]]],8,9]\r\n[1,[2,[3,[4,[5,6,0]]]],8,9]")]
        public void ProcessPart1Tests(long expectedValue, string input)
        {
            //Given 
            var inputLines = input.Split("\r\n");

            //When
            var output = Day13.ProcessPart1(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }

        [Theory]
        [InlineData(140, "[1,1,3,1,1]\r\n[1,1,5,1,1]\r\n\r\n[[1],[2,3,4]]\r\n[[1],4]\r\n\r\n[9]\r\n[[8,7,6]]\r\n\r\n[[4,4],4,4]\r\n[[4,4],4,4,4]\r\n\r\n[7,7,7,7]\r\n[7,7,7]\r\n\r\n[]\r\n[3]\r\n\r\n[[[]]]\r\n[[]]\r\n\r\n[1,[2,[3,[4,[5,6,7]]]],8,9]\r\n[1,[2,[3,[4,[5,6,0]]]],8,9]")]
        public void ProcessPart2Tests(long expectedValue, string input)
        {
            //Given 
            var inputLines = input.Split("\r\n");

            //When
            var output = Day13.ProcessPart2(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }
    }
}