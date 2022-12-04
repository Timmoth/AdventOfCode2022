
var input = File.ReadAllLines("./day4.csv");
var output = Day4.Process(input);
Console.WriteLine($"Total complete overlapping assignments pairs: \t{output.totalCompleteOverlappingAssignmentPairs}");
Console.WriteLine($"Total overlapping assignments pairs: \t{output.totalOverlappingAssignmentPairs}");
Console.Read();

public static class Day4
{
    public static (int totalCompleteOverlappingAssignmentPairs, int totalOverlappingAssignmentPairs) Process(string[] input)
    {
        (int totalCompleteOverlappingAssignmentPairs, int totalOverlappingAssignmentPairs) output = new();

        Span<string> inputAsSpan = input;
        for (int i = 0; i < inputAsSpan.Length; i++)
        {
            ReadOnlySpan<char> line = inputAsSpan[i];
            var delimiterIndex = line.IndexOf(',');
            var assignment1 = line.Slice(0, delimiterIndex);
            var assignment2 = line.Slice(delimiterIndex + 1, line.Length - (delimiterIndex + 1));

            var assignment1delimiterIndex = assignment1.IndexOf('-');
            var assignment1Start = int.Parse(assignment1.Slice(0, assignment1delimiterIndex));
            var assignment1End = int.Parse(assignment1.Slice(assignment1delimiterIndex + 1, assignment1.Length - (assignment1delimiterIndex + 1)));

            var assignment2delimiterIndex = assignment2.IndexOf('-');
            var assignment2Start = int.Parse(assignment2.Slice(0, assignment2delimiterIndex));
            var assignment2End = int.Parse(assignment2.Slice(assignment2delimiterIndex + 1, assignment2.Length - (assignment2delimiterIndex + 1)));

            //assignment 1 contains assignment 2 OR assignment 2 contains assignment 1
            if(assignment1Start <= assignment2Start && assignment1End >= assignment2End ||
                assignment2Start <= assignment1Start && assignment2End >= assignment1End)
            {
                output.totalCompleteOverlappingAssignmentPairs++;
                output.totalOverlappingAssignmentPairs++;
                continue;
            }

            //overlap
            if (assignment1Start <= assignment2Start && assignment1End >= assignment2Start || 
                assignment1Start <= assignment2End && assignment1End >= assignment2End)
            {
                output.totalOverlappingAssignmentPairs++;
                continue;
            }
        }

        return output;
    }
}
