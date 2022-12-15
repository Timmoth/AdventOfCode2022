using Xunit.Abstractions;

namespace Tests
{
    public class Day19Tests
    {
        public ITestOutputHelper _testOutputHelper { get; set; }

        public Day19Tests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Theory]
        [InlineData(0, "")]
        public void ProcessPart1Tests(long expectedValue, string input)
        {
            Day19.TestOutput = _testOutputHelper;
            //Given 
            var inputLines = input.Split("\r\n");

            //When
            var output = Day19.ProcessPart1(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }

        [Theory]
        [InlineData(0, "")]
        public void ProcessPart2Tests(long expectedValue, string input)
        {
            Day19.TestOutput = _testOutputHelper;
            //Given 
            var inputLines = input.Split("\r\n");

            //When
            var output = Day19.ProcessPart2(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }
    }
}