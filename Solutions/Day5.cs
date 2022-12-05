public static class Day5
{
    public static string ProcessPart1(string[] input)
    {
        var crateStacks = new Stack<char>[]
        {
            new Stack<char>(),
            new Stack<char>(),
            new Stack<char>(),
            new Stack<char>(),
            new Stack<char>(),
            new Stack<char>(),
            new Stack<char>(),
            new Stack<char>(),
            new Stack<char>(),
            new Stack<char>(),
        };

        var inputIndex = 0;
        var stackInput = new Stack<string>();
        string line;
        // Read initial crate config into stackInput (needs to be reversed)
        while ((line = input[inputIndex])[1] != '1')
        {
            stackInput.Push(line);
            inputIndex++;
        }

        //Skip next line with the numbers
        inputIndex++;

        // Populate crate stacks
        while (stackInput.TryPop(out line))
        {
            var stackIndex = 0;
            int lineIndex;
            while ((lineIndex = stackIndex * 4 + 1) < line.Length)
            {
                char c = line[lineIndex];
                if (c != ' ')
                {
                    crateStacks[stackIndex].Push(c);
                }

                stackIndex++;
            }
        }

        while (++inputIndex < input.Length)
        {
            line = input[inputIndex];

            var (amount, from, to) = DecodeInstruction(line);
            var fromStack = crateStacks[from - 1];
            var toStack = crateStacks[to - 1];

            for (int i = 0; i < amount; i++)
            {
                toStack.Push(fromStack.Pop());
            }
        }

        var output = "";
        for(int i = 0; i < crateStacks.Length; i++)
        {
            if(crateStacks[i].TryPeek(out var c))
            {
                output += c;
            }
        }

        return output;
    }

    public static string ProcessPart2(string[] input)
    {
        var crateStacks = new Stack<char>[]
        {
            new Stack<char>(),
            new Stack<char>(),
            new Stack<char>(),
            new Stack<char>(),
            new Stack<char>(),
            new Stack<char>(),
            new Stack<char>(),
            new Stack<char>(),
            new Stack<char>(),
            new Stack<char>(),
        };

        var inputIndex = 0;
        var stackInput = new Stack<string>();
        string line;
        // Read initial crate config into stackInput (needs to be reversed)
        while ((line = input[inputIndex])[1] != '1')
        {
            stackInput.Push(line);
            inputIndex++;
        }

        //Skip next line with the numbers
        inputIndex++;

        // Populate crate stacks
        while (stackInput.TryPop(out line))
        {
            var stackIndex = 0;
            int lineIndex;
            while ((lineIndex = stackIndex * 4 + 1) < line.Length)
            {
                char c = line[lineIndex];
                if (c != ' ')
                {
                    crateStacks[stackIndex].Push(c);
                }

                stackIndex++;
            }
        }

        while (++inputIndex < input.Length)
        {
            line = input[inputIndex];

            var (amount, from, to) = DecodeInstruction(line);
            var fromStack = crateStacks[from - 1];
            var toStack = crateStacks[to - 1];
            if (amount == 1)
            {
                toStack.Push(fromStack.Pop());
            }
            else
            {
                var crates = new char[amount];
                for (int i = 0; i < amount; i++)
                {
                    crates[i] = fromStack.Pop();
                }
                for (int i = amount - 1; i >= 0; i--)
                {
                    toStack.Push(crates[i]);
                }
            }
        }

        var output = "";
        for (int i = 0; i < crateStacks.Length; i++)
        {
            if (crateStacks[i].TryPeek(out var c))
            {
                output += c;
            }
        }

        return output;
    }

    private static (int amount,int from,int to) DecodeInstruction(string instruction)
    {
        int i = 0;

        var amount = "";
        for(; i < instruction.Length; i++)
        {
            var c = instruction[i];
            if(c is < '0' or > '9')
            {
                if(amount != "")
                {
                    break;
                }
                continue;
            }

            amount += c;
        }

        var from = "";
        for (; i < instruction.Length; i++)
        {
            var c = instruction[i];
            if (c is < '0' or > '9')
            {
                if (from != "")
                {
                    break;
                }
                continue;
            }

            from += c;
        }

        var to = "";
        for (; i < instruction.Length; i++)
        {
            var c = instruction[i];
            if (c is < '0' or > '9')
            {
                if (to != "")
                {
                    break;
                }
                continue;
            }

            to += c;
        }

        return (int.Parse(amount), int.Parse(from), int.Parse(to));
    }
}
