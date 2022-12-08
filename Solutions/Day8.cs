public static class Day8
{
    public enum Direction { North = 0, South = 1, East = 2, West = 3 };
    public class Tree
    {
        public Tree()
        {
        }

        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public int North { get; set; } = 0;
        public int South { get; set; } = 0;
        public int East { get; set; } = 0;
        public int West { get; set; } = 0;
        public int Height { get; set; } = 0;
    }

    public static int ProcessPart1(string[] input)
    {
        var gridHeight = input.Length;
        var gridWidth = input[0].Length;

        var trees = new Tree[gridHeight, gridWidth];

        var visibleTrees = new HashSet<string>();

        var highestTreeInColumnsIndex = new int[gridWidth];

        for (int y = 0; y < gridHeight; y++)
        {
            // Get the line from the input
            var line = input[y];

            // Stores the index of the highest tree in the row
            int highestTreeInRowIndex = 0;
            
            // Loop over each tree west -> east in the current row
            for (int x = 0; x < gridWidth; x++)
            {
                // Convert the ascii height to a byte
                var treeHeight = (byte)(line[x] - 48);

                // Create the tree & set its height
                var tree = trees[y, x] = new Tree()
                {
                    Height = treeHeight,
                    X = x,
                    Y = y
                };

                // Is the tree on the north edge? OR is the highest tree from the north shorter then this tree
                if (y == 0 || trees[y - 1, x].North < treeHeight)
                {
                    // This tree is visible from the north
                    tree.North = treeHeight;
                    highestTreeInColumnsIndex[x] = y;
                    visibleTrees.Add($"{x},{y}");
                }
                else
                {
                    // The highest tree from the north remains the same
                    tree.North = trees[y - 1, x].North;
                }

                // Is this tree on the west edge? OR is this the highest tree we've seen from the west so far
                if (x == 0 || trees[y, x - 1].West < treeHeight)
                {
                    tree.West = treeHeight;
                    highestTreeInRowIndex = x;
                    visibleTrees.Add($"{x},{y}");
                }
                else
                {
                    // The highest tree from the west remains the same
                    tree.West = trees[y, x - 1].West;
                }

                // Cannot make assumptions about South | East
            }

            // We only need to check if a tree is visible from the east up to the highest tree we've seen in the row so far
            // Since the highest tree will block anything to its west from being visible from the east
            for (int x = line.Length - 1; x > highestTreeInRowIndex; x--)
            {
                var tree = trees[y, x];

                // Is this tree on the east edge? OR is this the highest tree we've seen from the east so far
                if (x == line.Length - 1 || trees[y, x + 1].East < tree.Height)
                {
                    tree.East = tree.Height;
                    visibleTrees.Add($"{x},{y}");
                }
                else
                {
                    tree.East = trees[y, x + 1].East;
                }
            }
        }

        // Next we've got to scan each row from the bottom up
        for(int x = 0; x < gridWidth; x++)
        {
            int highestTreeInColumnIndex = highestTreeInColumnsIndex[x];
            for (int y = gridHeight-1; y > highestTreeInColumnIndex; y--)
            {
                var tree = trees[y, x];

                // Is this tree on the south edge? OR is this the highest tree we've seen from the south so far
                if (y == gridHeight-1 || trees[y + 1, x].South < tree.Height)
                {
                    tree.South = tree.Height;
                    visibleTrees.Add($"{x},{y}");
                }
                else
                {
                    tree.South = trees[y + 1, x].South;
                }
            }
        }

        return visibleTrees.Count;
    }

    public static int ProcessPart2(string[] input)
    {
        var gridHeight = input.Length;
        var gridWidth = input[0].Length;

        var trees = new Tree?[gridHeight, gridWidth];

        var scores = new List<int>();

        for (byte y = 0; y < gridHeight; y++)
        {
            for (byte x = 0; x < gridWidth; x++)
            {
                scores.Add(GetScenicScoreForTree((x, y), input, trees));
            }
        }

        return scores.Max();
    }

    public static int GetScenicScoreForTree((int x, int y) pos, string[] input, Tree?[,] trees)
    {
        var tree = GetTree(pos, input, trees);

        tree.GetFurthestTreeLine(input, trees, Direction.East);
        tree.GetFurthestTreeLine(input, trees, Direction.West);
        tree.GetFurthestTreeLine(input, trees, Direction.North);
        tree.GetFurthestTreeLine(input, trees, Direction.South);

        var north = tree.Y - tree.North;
        var south = tree.South - tree.Y;
        var east = tree.East - tree.X;
        var west = tree.X - tree.West;

        return north * south * east * west;
    }

    public static Tree? GetTree((int x, int y) pos, string[] input, Tree?[,] trees)
    {
        if (pos.x < 0 || pos.y < 0 || pos.y >= input.Length || pos.x >= input[0].Length)
        {
            // Tree out of bounds
            return null;
        }

        var tree = trees[pos.y, pos.x];
        if (tree != null)
        {
            // Tree already cached
            return tree;

        }
        // Cache new tree
        tree = trees[pos.y, pos.x] = new Tree()
        {
            // Decode ascii tree height from input
            Height = (byte)(input[pos.y][pos.x] - 48),
            X = pos.x, 
            Y = pos.y
        };

        return tree;
    }
    
    public static Tree? GetFurthestTreeLine(this Tree tree, string[] input, Tree?[,] trees, Direction dir)
    {
        // Try to get furthest tree from cache
        if(dir == Direction.North && tree.North > 0)
        {
            return GetTree((tree.X, tree.North), input, trees);
        }else if (dir == Direction.South && tree.South > 0)
        {
            return GetTree((tree.X, tree.South), input, trees);
        }
        else if (dir == Direction.East && tree.East > 0)
        {
            return GetTree((tree.East, tree.Y), input, trees);
        }
        else if (dir == Direction.West && tree.West > 0)
        {
            return GetTree((tree.West, tree.Y), input, trees);
        }
       
        Tree? furthestVisibleTree = tree;
        do
        {
            // Get the position of the next tree
            (int x, int y) nextTreePosition = dir switch
            {
                Direction.North => (furthestVisibleTree.X, furthestVisibleTree.Y - 1),
                Direction.South => (furthestVisibleTree.X, furthestVisibleTree.Y + 1),
                Direction.East => (furthestVisibleTree.X + 1, furthestVisibleTree.Y),
                Direction.West => (furthestVisibleTree.X - 1, furthestVisibleTree.Y),
                _ => (-1,-1)
            };

            // Get the next tree
            var nextTree = GetTree(nextTreePosition, input, trees);
            if(nextTree == null)
            {
                // No trees left in given direction
                break;
            }

            furthestVisibleTree = nextTree;
            if (furthestVisibleTree.Height >= tree.Height)
            {
                // Cannot see past next tree
                break;
            }

            nextTree = furthestVisibleTree.GetFurthestTreeLine(input, trees, dir);
            if (nextTree == null)
            {
                // No trees left in given direction
                break;
            }
            furthestVisibleTree = nextTree;

        } while (furthestVisibleTree.Height < tree.Height);

        tree.Update(dir, furthestVisibleTree);

        return furthestVisibleTree;
    }

    public static void Update(this Tree tree, Direction dir, Tree destTree)
    {
        switch (dir)
        {
            case Direction.North:
                tree.North = destTree.Y;
                break;
            case Direction.South:
                tree.South = destTree.Y;
                break;
            case Direction.East:
                tree.East = destTree.X;
                break;
            case Direction.West:
                tree.West = destTree.X;
                break;
        }
    }


}
