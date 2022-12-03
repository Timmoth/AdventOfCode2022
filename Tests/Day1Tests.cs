namespace Tests
{
    public class Day1Tests
    {
        [Theory]
        [InlineData(10, "10")]
        [InlineData(30, "10", "20")]
        [InlineData(20, "10", "", "20")]
        [InlineData(20, "10", "", "40", "20", "", "30")]
        public void GetMostCaloriesCarriedReturnsHighestCalories(int expetedValue, params string[] input)
        {
            //Given 
            var inputLines = input.ToArray();

            //When
            var highestCalories = Day1.GetMostCaloriesCarried(inputLines);

            //Then
            Assert.Equal(expetedValue, highestCalories);
        }
    }
}