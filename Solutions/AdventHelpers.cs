public static class AdventHelpers
{
    public static int ParseIntAtPosition(this ReadOnlySpan<char> line, ref int index, char delimeter)
    {
        var numStart = index;
        while (index < line.Length && line[index] != delimeter)
        {
            index++; // char is digit -> move forward
        }
        index++; // Skip delimeter

        return int.Parse(line[numStart..(index - 1)]);
    }
}
