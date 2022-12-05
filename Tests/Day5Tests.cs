namespace Tests
{
    public class Day5Tests
    {
        [Theory]
        [InlineData("CMZ",
            "    [D]", 
            "[N] [C]",
            "[Z] [M] [P]",
            " 1   2   3 ",
            "",
            "move 1 from 2 to 1",
            "move 3 from 1 to 3",
            "move 2 from 2 to 1",
            "move 1 from 1 to 2")]
        public void ProcessReturnsTopCratesOnEachStackForCrateMover9000(string expectedValue, params string[] input)
        {
            //Given 
            Day5.IsCrateMover9000 = true;
            var inputLines = input.ToArray();

            //When
            var output = Day5.Process(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }

        [Theory]
        [InlineData("MCD",
    "    [D]",
    "[N] [C]",
    "[Z] [M] [P]",
    " 1   2   3 ",
    "",
    "move 1 from 2 to 1",
    "move 3 from 1 to 3",
    "move 2 from 2 to 1",
    "move 1 from 1 to 2")]
        public void ProcessReturnsTopCratesOnEachStackForCrateMover9001(string expectedValue, params string[] input)
        {
            //Given 
            Day5.IsCrateMover9000 = false;
            var inputLines = input.ToArray();

            //When
            var output = Day5.Process(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }

    }
}