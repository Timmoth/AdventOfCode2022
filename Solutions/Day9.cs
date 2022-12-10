using System.ComponentModel;
using System.Runtime.CompilerServices;

public static class Day9
{
    public static int ProcessPart1(string[] input)
    {
        var visited = new HashSet<(int, int)>();
        
        // Create head & tail
        (int X, int Y) headPos = (0, 0);
        (int X, int Y) tailPos = (0, 0);

        // Add initial tail position
        visited.TryAdd(tailPos);

        for (var i = 0 ; i < input.Length; i++)
        {
            // Decode instruction
            var instruction = input[i].AsSpan();
            var dir = instruction[0];
            var dis = int.Parse(instruction[2..]);

            // For each step
            for(var j = 0; j < dis; j++)
            {
                // Move head
                headPos.MoveHead(dir);
                // Have tail follow head
                tailPos.Follow(headPos);
                // Record tails position
                visited.TryAdd(tailPos);
            }
        }
        return visited.Count;
    }
    public static int ProcessPart2(string[] input)
    {
        var visited = new HashSet<(int, int)>()
        {
             // Visit first position
             (0, 0)
        };

        // Create head + knots
        (int X, int Y) headPos = (0, 0);
        (int X, int Y)[] knots = {
            (0, 0),
            (0, 0),
            (0, 0),
            (0, 0),
            (0, 0),
            (0, 0),
            (0, 0),
            (0, 0),
            (0, 0),
        };

        for (var i = 0; i < input.Length; i++)
        {
            // Decode input
            var instruction = input[i].AsSpan();
            var dir = instruction[0];
            var dis = int.Parse(instruction[2..]);

            // For each step
            for (var j = 0; j < dis; j++)
            {
                // Move head
                headPos.MoveHead(dir);
                // First knot follows head
                knots[0].Follow(headPos);
                // Other knots follow prev knot
                for (int k = 1; k < knots.Length; k++)
                {
                    knots[k].Follow(knots[k - 1]);
                }
                // Visit tail pos
                visited.TryAdd(knots[^1]);
            }
        }
        return visited.Count;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void TryAdd(this HashSet<(int, int)> set, (int, int) item)
    {
        if (!set.Contains(item))
        {
            set.Add(item);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void MoveHead(this ref (int X, int Y) pos, char dir)
    {
        switch(dir) { 
            case 'U':
                pos.Y++;
                break;
            case 'D':
                pos.Y--;
                break;
            case 'L':
                pos.X--;
                break;
            case 'R':
                pos.X++;
                break;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Follow(this ref (int X, int Y) pos, (int X, int Y) target)
    {
        // Calculate delta 
        var stepX = target.X - pos.X;
        var stepY = target.Y - pos.Y;

        if (Math.Abs(stepX) <= 1 && Math.Abs(stepY) <= 1)
        {
            // touching target - no move
            return;
        }

        // Move max of one towards target
        pos.X += Math.Sign(stepX);
        pos.Y += Math.Sign(stepY);
    }
}
