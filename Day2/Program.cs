
var input = File.ReadAllLines("./day2.csv");
var output = Day2.Process(input);
Console.WriteLine($"Total score for part1: \t{output.part1Score}");
Console.WriteLine($"Total score for part2: \t{output.part2Score}");
Console.Read();

public static class Day2
{
    private static readonly int[][] OutcomeMatrix = new int[][]
    {
        new int[] { 3, 0, 6 },
        new int[] { 6, 3, 0 },
        new int[] { 0, 6, 3 },
    };

    private static readonly int[][] RequiredChoiceMatrix = new int[][]
    {
        new int[] { 2, 0, 1 },
        new int[] { 0, 1, 2 },
        new int[] { 1, 2, 0 },
    };
    public static (int part1Score, int part2Score) Process(string[] input)
    {
        (int part1Score, int part2Score) answer = (0, 0);

        Span<string> inputAsSpan = input;
        for (int i = 0; i < inputAsSpan.Length; i++)
        {
            ReadOnlySpan<char> line = inputAsSpan[i];
            int opponentsPlay = line[0] - 65;
            int secondColumn = line[2] - 88;

            //OutcomeMatrix: [Your play][Their play] => [Points]
            answer.part1Score += OutcomeMatrix[secondColumn][opponentsPlay] + secondColumn + 1;

            //RequiredChoiceMatrix: [Points][Their play] => [Your play]
            answer.part2Score += secondColumn * 3 + RequiredChoiceMatrix[secondColumn][opponentsPlay] + 1;
        }

        return answer;
    }
}
