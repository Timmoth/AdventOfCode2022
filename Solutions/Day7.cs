public static class Day7
{
    public static int ProcessPart1(string[] input)
    {
        var root = Parse(input);
        var directorySizes = new List<int>();
        GetDirectorySizes(root, directorySizes);
        return directorySizes.Where(x => x <= 100000).Sum();
    }

    public static int ProcessPart2(string[] input)
    {
        var root = Parse(input);
        var directorySizes = new List<int>();
        var totalSize = GetDirectorySizes(root, directorySizes);
        var spaceNeeded = 30000000 - (70000000 - totalSize);

        return directorySizes.Order().FirstOrDefault(x => x >= spaceNeeded);
    }

    public class Item
    {
        public string Name { get; set; } = string.Empty;
        public bool IsDir { get; set; } = false;
        public int Size { get; set; } = 0;
        public Item? Parent { get; set; } = null;
        public Dictionary<string, Item> Contents { get; set; } = new Dictionary<string, Item>();

        public void AddFile(ReadOnlySpan<char> line)
        {
            var dellimeterIndex = line.IndexOf(' ');

            var size = int.Parse(line[..dellimeterIndex]);
            var name = line.Slice(dellimeterIndex + 1, line.Length - dellimeterIndex - 1).ToString();
            if (!Contents.ContainsKey(name))
            {
                Contents[name] = new Item()
                {
                    Name = name,
                    Parent = this,
                    Size = size,
                    IsDir = false
                };
            }
        }

        public void AddDir(ReadOnlySpan<char> line)
        {
            var dirName = line[4..].ToString();
            if (!Contents.ContainsKey(dirName))
            {
                Contents[dirName] = new Item()
                {
                    Name = dirName,
                    Parent = this,
                    IsDir = true
                };
            }
        }
    }

    public static Item ExecuteCd(Item currentDir, ReadOnlySpan<char> line)
    {
        var dirName = line[5..].ToString();
        if (dirName == "..")
        {
            return currentDir.Parent;
        }
        else if (currentDir.Contents.TryGetValue(dirName, out var c))
        {
            return c;
        }
        else
        {
            return currentDir.Contents[dirName] = new Item()
            {
                Name = dirName,
                Parent = currentDir,
                IsDir = true
            };
        }
    }   
    
    public static Item Parse(string[] input)
    {
        var root = new Item()
        {
            Name = "/",
            IsDir = true
        };

        var currentDir = root;
        var i = 1;
        ReadOnlySpan<char> line;
        while (i < input.Length)
        {
            line = input[i];
            if (line[0] == '$')
            {
                //Command

                if (line[2] == 'c')
                {
                    //CD
                    currentDir = ExecuteCd(currentDir, line);
                    i++;
                }
                else
                {
                    // LS
                    i++;
                    while (i < input.Length)
                    {
                        //
                        line = input[i];

                        if (line[0] == '$')
                        {
                            // Next command - break
                            break;
                        }

                        if (line[0] == 'd')
                        {
                            // Directory
                            currentDir.AddDir(line);
                        }
                        else
                        {
                            // File
                            currentDir.AddFile(line);
                        }

                        i++;
                    }
                }
            }
        }

        return root;
    }

    public static int GetDirectorySizes(Item item, List<int> dirSizes)
    {
        if (!item.IsDir)
        {
            return item.Size;
        }

        item.Size = 0;
        foreach (var i in item.Contents)
        {
            item.Size += GetDirectorySizes(i.Value, dirSizes);
        }

        dirSizes.Add(item.Size);

        return item.Size;
    }
}
