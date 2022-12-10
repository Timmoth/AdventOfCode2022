using System.Text;

public static class Day10
{
    public static int ProcessPart1(string[] input)
    {
        var instructionIndex = 0;
        var cycleCount = 0;
        var register = 1;
        var signalStrength = 0;
        do
        {
            if (++cycleCount % 40 == 20)
            {
                signalStrength += register * cycleCount;
            }

            var line = input[instructionIndex].AsSpan();
            if (line[0] == 'a')
            {
                // addx opertation
                if (++cycleCount % 40 == 20)
                {
                    signalStrength += register * cycleCount;
                }

                register += int.Parse(line[4..]);
            }

            // Skip if noop
            
        }while(++instructionIndex < input.Length);

        return signalStrength;
    }

    public static string ProcessPart2(string[] input)
    {
        var instructionIndex = 0;
        var cycleCount = 0;
        var register = 1;
        var output = new StringBuilder();
        do
        {
            var pixelIndex = cycleCount % 40;
            output.Append(pixelIndex >= register - 1 && pixelIndex <= register + 1 ? '#' : '.');
            if (++cycleCount % 40 == 0)
            {
                output.AppendLine();
            }

            var line = input[instructionIndex].AsSpan();
            if (line[0] == 'a')
            {
                pixelIndex = cycleCount % 40;
                output.Append(pixelIndex >= register - 1 && pixelIndex <= register + 1 ? '#' : '.');
                if (++cycleCount % 40 == 0)
                {
                    output.AppendLine();
                }

                register += int.Parse(line[4..]);
            }

        } while (++instructionIndex < input.Length);

        return output.ToString();
    }
}
