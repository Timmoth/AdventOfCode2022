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

    public static int ProcessPart1(string[] input)
    {
        int answer = 0;

        Span<string> inputAsSpan = input;
        for (int i = 0; i < inputAsSpan.Length; i++)
        {
            ReadOnlySpan<char> line = inputAsSpan[i];
            int opponentsPlay = line[0] - 65;
            int secondColumn = line[2] - 88;

            //OutcomeMatrix: [Your play][Their play] => [Points]
            answer += OutcomeMatrix[secondColumn][opponentsPlay] + secondColumn + 1;
        }

        return answer;
    }

    public static int ProcessPart2(string[] input)
    {
        int answer = 0;

        Span<string> inputAsSpan = input;
        for (int i = 0; i < inputAsSpan.Length; i++)
        {
            ReadOnlySpan<char> line = inputAsSpan[i];
            int opponentsPlay = line[0] - 65;
            int secondColumn = line[2] - 88;

            //RequiredChoiceMatrix: [Points][Their play] => [Your play]
            answer += secondColumn * 3 + RequiredChoiceMatrix[secondColumn][opponentsPlay] + 1;
        }

        return answer;
    }
}
