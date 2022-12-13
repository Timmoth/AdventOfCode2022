public static class Day12
{
    public static int ProcessPart1(string[] input)
    {
        var nodes = new Node[input.Length][];

        Node start = default!;
        Node end = default!;
        for (int i = 0; i < input.Length; i++)
        {
            var inputLine = input[i];
            nodes[i] = new Node[inputLine.Length];
            for (var j = 0; j < inputLine.Length; j++)
            {
                var node = nodes[i][j] = new Node()
                {
                    Height = inputLine[j],
                    X = j,
                    Y = i
                };

                if (node.Height == 'S')
                {
                    start = nodes[i][j];
                    start.Height = 'a';
                }
                else if (node.Height == 'E')
                {
                    end = nodes[i][j];
                    end.Height = 'z';
                }
            }
        }

        return nodes.GetShortestPath(start, end).ShortestDistance;
    }

    public static int ProcessPart2(string[] input)
    {
        var nodes = new Node[input.Length][];
        var end = new List<Node>();
        Node start = default!;
        for (int i = 0; i < input.Length; i++)
        {
            var inputLine = input[i];
            nodes[i] = new Node[inputLine.Length];
            for (var j = 0; j < inputLine.Length; j++)
            {
                var node = nodes[i][j] = new Node()
                {
                    Height = inputLine[j],
                    X = j,
                    Y = i
                };

                if (node.Height == 'a')
                {
                    end.Add(nodes[i][j]);
                }
                else if(node.Height == 'S')
                {
                    var n = nodes[i][j];
                    n.Height = 'a';
                    end.Add(n);
                }
                else if (node.Height == 'E')
                {
                    start = nodes[i][j];
                    start.Height = 'z';
                }
            }
        }

        return nodes.GetShortestPath(end, start);
    }

    public class Node
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int ShortestDistance { get; set; } = int.MaxValue;
        public bool Visited { get; set; } = false;
        public void Clear()
        {
            ShortestDistance = int.MaxValue;
            Visited = false;
        }
    }

    public static int GetShortestPath(this Node[][] nodes, List<Node> startNodes, Node end)
    {
        var shortestPaths = new Dictionary<Node, int>();

        var min = int.MaxValue;
        foreach(var start in startNodes)
        {
            foreach (var n in nodes.SelectMany(n => n))
            {
                n.Clear();
            }

            var path = nodes.GetShortestPath(start, end);

            if (path.Visited && path.ShortestDistance < min)
            {
                min = path.ShortestDistance;
            }
        }

        return min;
    }

    public static Node GetShortestPath(this Node[][] nodes, Node start, Node end)
    {
        var visitedNodes = new HashSet<Node>();
        var nextNodes = new PriorityQueue<Node,int>();
        start.Visited = true;
        start.ShortestDistance = 0;
        visitedNodes.Add(start);
        nextNodes.GetNeighbours(nodes, start);

        while (!end.Visited && nextNodes.Count > 0)
        {
            nextNodes.TryDequeue(out var closestNeighbour, out var _);
            if (closestNeighbour.Visited)
            {
                continue;
            }

            closestNeighbour.Visited = true;
            visitedNodes.Add(closestNeighbour);
            nextNodes.GetNeighbours(nodes, closestNeighbour);
        }

        return end;
    }

    public static void GetNeighbours(this PriorityQueue<Node, int> next, Node[][] nodes, Node node)
    {
        if(node.X - 1 >= 0)
        {
            var nextNode = nodes[node.Y][node.X - 1];
            if(!nextNode.Visited && nextNode.Height <= node.Height + 1)
            {
                if (node.ShortestDistance + 1 < nextNode.ShortestDistance)
                {
                    nextNode.ShortestDistance = node.ShortestDistance + 1;
                    next.Enqueue(nextNode, nextNode.ShortestDistance);
                }
            }
        }

        if (node.X + 1 < nodes[0].Length)
        {
            var nextNode = nodes[node.Y][node.X + 1];
            if (!nextNode.Visited && nextNode.Height <= node.Height + 1)
            {
                if (node.ShortestDistance + 1 < nextNode.ShortestDistance)
                {
                    nextNode.ShortestDistance = node.ShortestDistance + 1;
                    next.Enqueue(nextNode, nextNode.ShortestDistance);
                }
            }
        }

        if (node.Y - 1 >= 0)
        {
            var nextNode = nodes[node.Y - 1][node.X];
            if (!nextNode.Visited && nextNode.Height <= node.Height + 1)
            {
                if (node.ShortestDistance + 1 < nextNode.ShortestDistance)
                {
                    nextNode.ShortestDistance = node.ShortestDistance + 1;
                    next.Enqueue(nextNode, nextNode.ShortestDistance);
                }
            }
        }

        if (node.Y + 1 < nodes.Length)
        {
            var nextNode = nodes[node.Y + 1][node.X];
            if (!nextNode.Visited && nextNode.Height <= node.Height + 1)
            {
                if(node.ShortestDistance + 1 < nextNode.ShortestDistance)
                {
                    nextNode.ShortestDistance = node.ShortestDistance + 1;
                    next.Enqueue(nextNode, nextNode.ShortestDistance);
                }
            }
        }
    }
}