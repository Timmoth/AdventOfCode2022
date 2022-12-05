namespace Tests
{
    public class Day4Tests
    {
        [Theory]
        [InlineData(0, "1-2,3-4")]
        [InlineData(2, "2-4,6-8", "2-3,4-5", "5-7,7-9", "2-8,3-7", "6-6,4-6", "2-6,4-8")]
        public void ProcessReturnsTotalNumberOfCompleteOverlappingAssignmentPairs(int expectedValue, params string[] input)
        {
            //Given 
            var inputLines = input.ToArray();

            //When
            var output = Day4.ProcessPart1(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }

        [Theory]
        [InlineData(0, "1-2,3-4")]
        [InlineData(1, "1-2,2-4")]
        [InlineData(4, "2-4,6-8", "2-3,4-5", "5-7,7-9", "2-8,3-7", "6-6,4-6", "2-6,4-8")]
        public void ProcessReturnsTotalNumberOfOverlappingAssignmentPairs(int expectedValue, params string[] input)
        {
            //Given 
            var inputLines = input.ToArray();

            //When
            var output = Day4.ProcessPart2(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }
    }
}