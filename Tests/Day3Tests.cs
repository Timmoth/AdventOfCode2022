namespace Tests
{
    public class Day3Tests
    {
        [Theory]
        [InlineData(1, "aa")]
        [InlineData(27, "AA")]
        [InlineData(2, "abbc")]
        [InlineData(52, "aba", "ZZ")]
        [InlineData(157, "vJrwpWtwJgWrhcsFMMfFFhFp", "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL", "PmmdzqPrVvPwwTWBwg", "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn", "ttgJtRGJQctTZtZT", "CrZsJsPPZsGzwwsLwLmpwMDw")]
        public void CalculateTotalPriorityReturnsTotalPriority(int expectedValue, params string[] input)
        {
            //Given 
            var inputLines = input.ToArray();

            //When
            var output = Day3.Process(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }
    }
}