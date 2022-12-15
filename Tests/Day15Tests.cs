using Xunit.Abstractions;

namespace Tests
{
    public class Day15Tests
    {
        public ITestOutputHelper _testOutputHelper { get; set; }

        public Day15Tests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Theory]
        [InlineData(26, "Sensor at x=2, y=18: closest beacon is at x=-2, y=15\r\nSensor at x=9, y=16: closest beacon is at x=10, y=16\r\nSensor at x=13, y=2: closest beacon is at x=15, y=3\r\nSensor at x=12, y=14: closest beacon is at x=10, y=16\r\nSensor at x=10, y=20: closest beacon is at x=10, y=16\r\nSensor at x=14, y=17: closest beacon is at x=10, y=16\r\nSensor at x=8, y=7: closest beacon is at x=2, y=10\r\nSensor at x=2, y=0: closest beacon is at x=2, y=10\r\nSensor at x=0, y=11: closest beacon is at x=2, y=10\r\nSensor at x=20, y=14: closest beacon is at x=25, y=17\r\nSensor at x=17, y=20: closest beacon is at x=21, y=22\r\nSensor at x=16, y=7: closest beacon is at x=15, y=3\r\nSensor at x=14, y=3: closest beacon is at x=15, y=3\r\nSensor at x=20, y=1: closest beacon is at x=15, y=3")]
        public void ProcessPart1Tests(long expectedValue, string input)
        {
            Day15.TestOutput = _testOutputHelper;
            //Given 
            var inputLines = input.Split("\r\n");

            //When
            var output = Day15.ProcessPart1(inputLines, 10);

            //Then
            Assert.Equal(expectedValue, output);
        }

        [Theory]
        [InlineData(56000011, "Sensor at x=2, y=18: closest beacon is at x=-2, y=15\r\nSensor at x=9, y=16: closest beacon is at x=10, y=16\r\nSensor at x=13, y=2: closest beacon is at x=15, y=3\r\nSensor at x=12, y=14: closest beacon is at x=10, y=16\r\nSensor at x=10, y=20: closest beacon is at x=10, y=16\r\nSensor at x=14, y=17: closest beacon is at x=10, y=16\r\nSensor at x=8, y=7: closest beacon is at x=2, y=10\r\nSensor at x=2, y=0: closest beacon is at x=2, y=10\r\nSensor at x=0, y=11: closest beacon is at x=2, y=10\r\nSensor at x=20, y=14: closest beacon is at x=25, y=17\r\nSensor at x=17, y=20: closest beacon is at x=21, y=22\r\nSensor at x=16, y=7: closest beacon is at x=15, y=3\r\nSensor at x=14, y=3: closest beacon is at x=15, y=3\r\nSensor at x=20, y=1: closest beacon is at x=15, y=3")]
        public void ProcessPart2Tests(long expectedValue, string input)
        {
            Day15.TestOutput = _testOutputHelper;
            //Given 
            var inputLines = input.Split("\r\n");

            //When
            var output = Day15.ProcessPart2(inputLines, 20);

            //Then
            Assert.Equal(expectedValue, output);
        }
    }
}