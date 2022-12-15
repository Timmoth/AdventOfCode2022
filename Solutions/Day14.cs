using System.Text;
using Xunit.Abstractions;
public static class Day14
{
    public static ITestOutputHelper? TestOutput { get; set; } = null;
    public static int ProcessPart1(string[] input)
    {
        var rockSegments = ParseInput(input);
        var grid = GetGrid(rockSegments);

        #if DEBUG
            TestOutput?.Print(grid);
        #endif

        var sandStacked = 0;
        while (true)
        {
            var sandPosition = (500 - rockSegments.minX, 0);
            bool? isSandAtRest;
            while ((isSandAtRest = CanSandRest(grid, ref sandPosition)) is false)
            {
                // Sand cannot rest at sandPosition try again
            }

            if (!isSandAtRest.HasValue)
            {
                // Sand fell into the abyss!
                return sandStacked;
            }
            else
            {
                // Sand rests here
                sandStacked += 1;
                grid[sandPosition.Item2, sandPosition.Item1] = 2;
#if DEBUG
                TestOutput?.Print(grid);
#endif
            }
        }
    }

    public static int ProcessPart2(string[] input)
    {
        var rockSegments = ParseInput(input);
        rockSegments.maxY += 2;
        rockSegments.minX -= 200;
        rockSegments.maxX += 200;

        rockSegments.Item1.Add(new List<(int X, int Y)>()
        {
            { (rockSegments.minX, rockSegments.maxY) },
            { (rockSegments.maxX, rockSegments.maxY) },
        });

        var grid = GetGrid(rockSegments);

#if DEBUG
        TestOutput?.Print(grid);
#endif

        int sandStack = 0;
        while (true)
        {
            var sandPosition = (500 - rockSegments.minX, 0);
            bool? isSandAtRest;
            while ((isSandAtRest = CanSandRest(grid, ref sandPosition)) is false)
            {

            }

            if (sandPosition.Item2 == 0)
            {
                // Sand reached top!
                return ++sandStack;
            }
            else
            {
                // Sand rests here
                sandStack += 1;
                grid[sandPosition.Item2, sandPosition.Item1] = 2;
#if DEBUG
                TestOutput?.Print(grid);
#endif
            }
        }
    }


    public static (List<List<(int X, int Y)>>, int minX, int maxX, int maxY) ParseInput(string[] input)
    {
        var segments = new List<List<(int X, int Y)>>();

        var minX = int.MaxValue;
        var maxX = 0;
        var maxY = 0;
        for (int i = 0; i < input.Length; i++)
        {
            var connectedSegments = new List<(int X, int Y)>();
            var line = input[i].AsSpan();
            var lineIndex = 0;
            while (lineIndex < line.Length)
            {
                var x = AdventHelpers.ParseIntAtPosition(line, ref lineIndex, ',');
                var y = AdventHelpers.ParseIntAtPosition(line, ref lineIndex, ' ');

                if (x < minX)
                {
                    // Set min X
                    minX = x;
                }
                else if (x > maxX)
                {
                    // Set max X
                    maxX = x;
                }

                if (y > maxY)
                {
                    // Set max Y
                    maxY = y;
                }

                connectedSegments.Add((x, y));
                lineIndex += 3; // Ignore seperator ' -> '
            }

            segments.Add(connectedSegments);
        }

        return (segments, minX, maxX, maxY);
    }

    public static int[,] GetGrid((List<List<(int X, int Y)>>, int minX, int maxX, int maxY) input)
    {
        var (segments, minX, maxX, maxY) = input;

        // Draw segments on grid
        var grid = new int[maxY + 1, maxX + 1 - minX];
        for (int i = 0; i < segments.Count; i++)
        {
            var segment = segments[i];
            for (int j = 1; j < segment.Count; j++)
            {
                var a = segment[j - 1];
                var b = segment[j];
   
                //Add rocksegments at position
                grid[a.Y, a.X - minX] = 1;
                grid[b.Y, b.X - minX] = 1;

                // Add horizontal rock segments
                var minSegmentX = Math.Min(a.X, b.X);
                var maxSegmentX = Math.Max(a.X, b.X);
                for (int k = minSegmentX; k < maxSegmentX; k++)
                {
                    grid[a.Y, k - minX] = 1;
                }

                // Add vertical rock segments
                var minSegmentY = Math.Min(a.Y, b.Y);
                var maxSegmentY = Math.Max(a.Y, b.Y);
                for (int k = minSegmentY; k < maxSegmentY; k++)
                {
                    grid[k, a.X - minX] = 1;
                }
            }
        }

        return grid;
    }

    public static bool? CanSandRest(int[,] grid, ref (int X, int Y) pos)
    {
        if(pos.Y + 1 >= grid.GetLength(0)){
            return null; // Into abys
        }

        if (pos.X >= grid.GetLength(1) || pos.X < 0)
        {
            return null; // Into abys
        }

        if (grid[pos.Y + 1, pos.X] == 0)
        {
            pos.Y++;
            return false;// Is at rest
        }
        else
        {
            if (pos.X - 1 < 0)
            {
                return null; // Into abys
            }

            if (grid[pos.Y + 1, pos.X - 1] == 0)
            {
                pos.X--;
                pos.Y++;
                return false; // Can move diagonally
            }

            if (pos.X + 1 >= grid.GetLength(1))
            {
                return null; // Into abys
            }

            if (grid[pos.Y + 1, pos.X + 1] == 0)
            {
                pos.X++;
                pos.Y++;
                return false; // Can move diagonally
            }
        }

        return true;
    }

    public static void Print(this ITestOutputHelper output, int[,] grid)
    {
        output.WriteLine("------------");
        for (int y = 0; y < grid.GetLength(0); y++)
        {
            var line = new StringBuilder();
            for(int x = 0; x < grid.GetLength(1); x++)
            {
                line.Append(grid[y, x].ToString());
            }

            output.WriteLine(line.ToString());
        }
    }
}