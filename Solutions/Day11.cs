public static class Day11
{
    public class Monkey
    {
        public Queue<long> Items { get; } = new Queue<long>();
        public Func<long, long> Operation { get; set; }
        public int TestDivisibleBy { get; set; }
        public int TestPassMonkeyDestination { get; set; }
        public int TestFailMonkeyDestination { get; set; }
        public int GetMonkeyDestination(long item)
        {
            return item % TestDivisibleBy == 0 ? TestPassMonkeyDestination : TestFailMonkeyDestination;
        }
        public long Activity { get; private set; } = 0;
        public void IncrementActivity()
        {
            Activity += Items.Count;
        }
    }

    public static Func<long, long> ParseOperation(ReadOnlySpan<char> line)
    {
        var operation = line[23];
        if (line[25] != 'o')
        {
            var operationRhs = long.Parse(line[24..]);// RHS is numerical value

            if (operation == '*')
            {
                return (i) => (i * operationRhs);
            }
            else
            {
                return (i) => (i + operationRhs);
            }
        }

        if(operation == '*')
        {
            return (i) => (i * i);
        }
        else
        {
            return (i) => (i + i);
        }
    }

    public static long ProcessPart1(string[] input)
    {
        var monkeys = LoadMonkeys(input);

        for (int i = 0; i < 20; i++)
        {
            for(int j = 0; j < monkeys.Length; j++)
            {
                var monkey = monkeys[j];
                monkey.IncrementActivity();
                while(monkey.Items.TryDequeue(out var item))
                {
                    var newWorry = (long)Math.Floor(monkey.Operation(item) / 3.0f);
                    var destMonkeyIndex = monkey.GetMonkeyDestination(newWorry);
                    monkeys[destMonkeyIndex].Items.Enqueue(newWorry);
                }
            }
        }

        var orderedMonkeys = monkeys.OrderByDescending(m => m.Activity);
        return orderedMonkeys.ElementAt(0).Activity * orderedMonkeys.ElementAt(1).Activity;
    }

    private static Monkey[] LoadMonkeys(string[] input)
    {
        var monkeyCount = input.Length / 7;
        var monkeys = new Monkey[monkeyCount];
        int inputIndex = 0;
        var monkeyIndex = 0;

        while (inputIndex < input.Length)
        {
            var monkey = new Monkey();
            inputIndex++; // Skip monkey index line
            var items = input[inputIndex++][18..].Split(',').Select(long.Parse);// parse all monkey starting items
            foreach (var item in items)
            {
                monkey.Items.Enqueue(item);
            }

            monkey.Operation = ParseOperation(input[inputIndex++].AsSpan());// parse monkey operation line
            monkey.TestDivisibleBy = int.Parse(input[inputIndex++].AsSpan()[21..]);
            monkey.TestPassMonkeyDestination = int.Parse(input[inputIndex++].AsSpan()[29..]);
            monkey.TestFailMonkeyDestination = int.Parse(input[inputIndex++].AsSpan()[30..]);
            inputIndex++; // Skip space between two monkeys
            monkeys[monkeyIndex++] = monkey;
        }

        return monkeys;
    }

    public static long ProcessPart2(string[] input)
    {
        var monkeys = LoadMonkeys(input);

        var commonDeviser = 1;
        for(int i =0; i < monkeys.Length; i++)
        {
            commonDeviser *= monkeys[i].TestDivisibleBy;
        }

        for (int i = 0; i < 10000; i++)
        {
            for (int j = 0; j < monkeys.Length; j++)
            {
                var monkey = monkeys[j];
                monkey.IncrementActivity();
                while (monkey.Items.TryDequeue(out var item))
                {
                    var newWorry = monkey.Operation(item) % commonDeviser;
                    var destMonkeyIndex = monkey.GetMonkeyDestination(newWorry);
                    monkeys[destMonkeyIndex].Items.Enqueue(newWorry);
                }
            }
        }

        var orderedMonkeys = monkeys.OrderByDescending(m => m.Activity);
        return orderedMonkeys.ElementAt(0).Activity * orderedMonkeys.ElementAt(1).Activity;
    }
}
