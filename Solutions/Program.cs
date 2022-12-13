Console.Write("Select a day to run: ");
if (!int.TryParse(Console.ReadLine(), out var selection))
{
    Console.Write("Could not parse given day.");
}

string[] input;

switch (selection)
{
    case 1:
        input = File.ReadAllLines("./Day1.csv");
        Console.WriteLine($"Part1: \t{Day1.ProcessPart1(input)}");
        Console.WriteLine($"Part2: \t{Day1.ProcessPart2(input)}");
        break;
    case 2:
        input = File.ReadAllLines("./Day2.csv");
        Console.WriteLine($"Part1: \t{Day2.ProcessPart1(input)}");
        Console.WriteLine($"Part2: \t{Day2.ProcessPart2(input)}");
        break;
    case 3:
        input = File.ReadAllLines("./Day3.csv");
        Console.WriteLine($"Part1: \t{Day3.ProcessPart1(input)}");
        Console.WriteLine($"Part2: \t{Day3.ProcessPart2(input)}");
        break;
    case 4:
        input = File.ReadAllLines("./Day4.csv");
        Console.WriteLine($"Part1: \t{Day4.ProcessPart1(input)}");
        Console.WriteLine($"Part2: \t{Day4.ProcessPart2(input)}");
        break;
    case 5:
        input = File.ReadAllLines("./Day5.csv");
        Console.WriteLine($"Part1: \t{Day5.ProcessPart1(input)}");
        Console.WriteLine($"Part2: \t{Day5.ProcessPart2(input)}");
        break;
    case 6:
        input = File.ReadAllLines("./Day6.csv");
        Console.WriteLine($"Part1: \t{Day6.ProcessPart1(input[0])}");
        Console.WriteLine($"Part2: \t{Day6.ProcessPart2(input[0])}");
        break;
    case 7:
        input = File.ReadAllLines("./Day7.csv");
        Console.WriteLine($"Part1: \t{Day7.ProcessPart1(input)}");
        Console.WriteLine($"Part2: \t{Day7.ProcessPart2(input)}");
        break;
    case 8:
        input = File.ReadAllLines("./Day8.csv");
        Console.WriteLine($"Part1: \t{Day8.ProcessPart1(input)}");
        Console.WriteLine($"Part2: \t{Day8.ProcessPart2(input)}");
        break;
    case 9:
        input = File.ReadAllLines("./Day9.csv");
        Console.WriteLine($"Part1: \t{Day9.ProcessPart1(input)}");
        Console.WriteLine($"Part2: \t{Day9.ProcessPart2(input)}");
        break;
    case 10:
        input = File.ReadAllLines("./Day10.csv");
        Console.WriteLine($"Part1: \t{Day10.ProcessPart1(input)}");
        Console.WriteLine($"Part2: \t{Day10.ProcessPart2(input)}");
        break;
    case 11:
        input = File.ReadAllLines("./Day11.csv");
        Console.WriteLine($"Part1: \t{Day11.ProcessPart1(input)}");
        Console.WriteLine($"Part2: \t{Day11.ProcessPart2(input)}");
        break;
    case 12:
        input = File.ReadAllLines("./Day12.csv");
        Console.WriteLine($"Part1: \t{Day12.ProcessPart1(input)}");
        Console.WriteLine($"Part2: \t{Day12.ProcessPart2(input)}");
        break;
    case 13:
        input = File.ReadAllLines("./Day13.csv");
        Console.WriteLine($"Part1: \t{Day13.ProcessPart1(input)}");
        Console.WriteLine($"Part2: \t{Day13.ProcessPart2(input)}");
        break;
    default:
        Console.WriteLine($"Day not found!");
        break;
}

Console.ReadLine();