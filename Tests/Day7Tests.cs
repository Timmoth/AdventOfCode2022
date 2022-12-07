namespace Tests
{
    public class Day7Tests
    {
        [Theory]
        [InlineData(95437, "$ cd /\r\n$ ls\r\ndir a\r\n14848514 b.txt\r\n8504156 c.dat\r\ndir d\r\n$ cd a\r\n$ ls\r\ndir e\r\n29116 f\r\n2557 g\r\n62596 h.lst\r\n$ cd e\r\n$ ls\r\n584 i\r\n$ cd ..\r\n$ cd ..\r\n$ cd d\r\n$ ls\r\n4060174 j\r\n8033020 d.log\r\n5626152 d.ext\r\n7214296 k")]
        public void ProcessReturnsTotalSizeOfLargestDirectories(int expectedValue, string input)
        {
            //Given 
            var inputLines = input.Split("\r\n");
            //When
            var output = Day7.ProcessPart1(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }

        [Theory]
        [InlineData(24933642, "$ cd /\r\n$ ls\r\ndir a\r\n14848514 b.txt\r\n8504156 c.dat\r\ndir d\r\n$ cd a\r\n$ ls\r\ndir e\r\n29116 f\r\n2557 g\r\n62596 h.lst\r\n$ cd e\r\n$ ls\r\n584 i\r\n$ cd ..\r\n$ cd ..\r\n$ cd d\r\n$ ls\r\n4060174 j\r\n8033020 d.log\r\n5626152 d.ext\r\n7214296 k")]
        public void ProcessReturnsTotalSizeOfLargestDirectories2(int expectedValue, string input)
        {
            //Given 
            var inputLines = input.Split("\r\n");
            //When
            var output = Day7.ProcessPart2(inputLines);

            //Then
            Assert.Equal(expectedValue, output);
        }
    }
}