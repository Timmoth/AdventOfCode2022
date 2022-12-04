
var input = File.ReadAllLines("./day3.csv");
var output = Day3.Process(input);
Console.WriteLine($"Total priority for duplicate items: \t{output.totalPriorityForDuplicateItems}");
Console.WriteLine($"Total priority for each group: \t{output.totalPriorityForEachGroup}");
Console.Read();

public static class Day3
{
    public static (int totalPriorityForDuplicateItems, int totalPriorityForEachGroup) Process(string[] input)
    {
        (int totalPriorityForDuplicateItems, int totalPriorityForEachGroup) output = new();

        ReadOnlySpan<char> elfA = null;
        ReadOnlySpan<char> elfB = null;

        Span<string> inputAsSpan = input;
        for (int i = 0; i < inputAsSpan.Length; i++)
        {
            ReadOnlySpan<char> line = inputAsSpan[i];
            output.totalPriorityForDuplicateItems += GetElfDuplicateItemPriority(line);

            if(elfA == null)
            {
                elfA = line;
            }else if(elfB == null)
            {
                elfB = line;
            }
            else
            {
                output.totalPriorityForEachGroup += GetElfGroupBadgePriority(elfA, elfB, line);
                elfA = null;
                elfB = null;
            }
        }

        return output;
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
