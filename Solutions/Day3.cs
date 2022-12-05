public static class Day3
{
    public static int ProcessPart1(string[] input)
    {
        int answer = 0;

        Span<string> inputAsSpan = input;
        for (int i = 0; i < inputAsSpan.Length; i++)
        {
            ReadOnlySpan<char> line = inputAsSpan[i];
            answer += GetElfDuplicateItemPriority(line);
        }

        return answer;
    }

    public static int ProcessPart2(string[] input)
    {
        int answer = 0;

        ReadOnlySpan<char> elfA = null;
        ReadOnlySpan<char> elfB = null;

        Span<string> inputAsSpan = input;
        for (int i = 0; i < inputAsSpan.Length; i++)
        {
            ReadOnlySpan<char> line = inputAsSpan[i];

            if(elfA == null)
            {
                elfA = line;
            }else if(elfB == null)
            {
                elfB = line;
            }
            else
            {
                answer += GetElfGroupBadgePriority(elfA, elfB, line);
                elfA = null;
                elfB = null;
            }
        }

        return answer;
    }
    private static int GetElfDuplicateItemPriority(ReadOnlySpan<char> line)
    {
        var midPoint = line.Length / 2;
        var compartmentOne = line[..midPoint];
        var compartmentTwo = line.Slice(midPoint, midPoint);

        for (int i = 0; i < compartmentTwo.Length; i++)
        {
            var item = compartmentTwo[i];
            if (compartmentOne.Contains(item))
            {
                return item - (char.IsUpper(item) ? 38 : 96);
            }
        }

        return 0;
    }

    private static int GetElfGroupBadgePriority(ReadOnlySpan<char> elfA, ReadOnlySpan<char> elfB, ReadOnlySpan<char> elfC)
    {
        for (int i = 0; i < elfA.Length; i++)
        {
            var item = elfA[i];
            if(elfB.Contains(item) && elfC.Contains(item))
            {
                return item - (char.IsUpper(item) ? 38 : 96);
            }
        }
        
        return 0;
    }
}
