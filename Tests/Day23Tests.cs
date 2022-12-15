using Xunit.Abstractions;

namespace Tests
{
    public class Day23Tests
    {
        public ITestOutputHelper _testOutputHelper { get; set; }

        public Day23Tests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Theory]
        [InlineData(0, "")]
        public void ProcessPart1Tests(long expectedValue, string input)
        {
            Day23.TestOutput = _testOutputHelper;
            //Given 
            var inputLines = input.Split("\r\n");

            //When
            var output = Day23.ProcessPart1(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }

        [Theory]
        [InlineData(0, "")]
        public void ProcessPart2Tests(long expectedValue, string input)
        {
            Day23.TestOutput = _testOutputHelper;
            //Given 
            var inputLines = input.Split("\r\n");

            //When
            var output = Day23.ProcessPart2(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }
    }
}