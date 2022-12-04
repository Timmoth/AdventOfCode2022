
var input = File.ReadAllLines("./day2.csv");
var score = Day2.CalculateScore(input);

Console.WriteLine(score);
Console.Read();

public static class Day2
{
    private static readonly int[][] OutcomeMatrix = new int[][]
    {
        new int[] { 3, 0, 6 },
        new int[] { 6, 3, 0 },
        new int[] { 0, 6, 3 },
    };
    public static int CalculateScore(string[] input)
    {
        int score = 0;

        Span<string> inputAsSpan = input;
        for (int i = 0; i < inputAsSpan.Length; i++)
        {
            var line = inputAsSpan[i];
            int opponentsPlay = line[0] - 65;
            int yourPlay = line[2] - 88;
            score += OutcomeMatrix[yourPlay][opponentsPlay] + yourPlay + 1;
        }

        return score;
    }
}
