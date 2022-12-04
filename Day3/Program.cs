
var input = File.ReadAllLines("./day3.csv");
var score = Day3.CalculateTotalPriority(input);

Console.WriteLine(score);
Console.Read();

public static class Day3
{
    public static int CalculateTotalPriority(string[] input)
    {
        int totalPriority = 0;

        Span<string> inputAsSpan = input;
        for (int i = 0; i < inputAsSpan.Length; i++)
        {
            ReadOnlySpan<char> line = inputAsSpan[i];
            var midPoint = line.Length / 2;
            var compartmentOne = line[..midPoint];
            var compartmentTwo = line.Slice(midPoint, midPoint);

            for(int j = 0; j < compartmentTwo.Length; j++)
            {
                var item = compartmentTwo[j];
                if (compartmentOne.Contains(item))
                {
                    totalPriority += item - (char.IsUpper(item) ? 38 : 96);
                    break;
                }
            }
        }

        return totalPriority;
    }
}
