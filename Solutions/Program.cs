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
    case 14:
        input = File.ReadAllLines("./Day14.csv");
        Console.WriteLine($"Part1: \t{Day14.ProcessPart1(input)}");
        Console.WriteLine($"Part2: \t{Day14.ProcessPart2(input)}");
        break;
    case 15:
        input = File.ReadAllLines("./Day15.csv");
        Console.WriteLine($"Part1: \t{Day15.ProcessPart1(input, 2000000)}");
        Console.WriteLine($"Part2: \t{Day15.ProcessPart2(input, 4000000)}");
        break;
    case 16:
        input = File.ReadAllLines("./Day16.csv");
        Console.WriteLine($"Part1: \t{Day16.ProcessPart1(input)}");
        Console.WriteLine($"Part2: \t{Day16.ProcessPart2(input)}");
        break;
    case 17:
        input = File.ReadAllLines("./Day17.csv");
        Console.WriteLine($"Part1: \t{Day17.ProcessPart1(input)}");
        Console.WriteLine($"Part2: \t{Day17.ProcessPart2(input)}");
        break;
    case 18:
        input = File.ReadAllLines("./Day18.csv");
        Console.WriteLine($"Part1: \t{Day18.ProcessPart1(input)}");
        Console.WriteLine($"Part2: \t{Day18.ProcessPart2(input)}");
        break;
    case 19:
        input = File.ReadAllLines("./Day19.csv");
        Console.WriteLine($"Part1: \t{Day19.ProcessPart1(input)}");
        Console.WriteLine($"Part2: \t{Day19.ProcessPart2(input)}");
        break;
    case 20:
        input = File.ReadAllLines("./Day20.csv");
        Console.WriteLine($"Part1: \t{Day20.ProcessPart1(input)}");
        Console.WriteLine($"Part2: \t{Day20.ProcessPart2(input)}");
        break;
    case 21:
        input = File.ReadAllLines("./Day21.csv");
        Console.WriteLine($"Part1: \t{Day21.ProcessPart1(input)}");
        Console.WriteLine($"Part2: \t{Day21.ProcessPart2(input)}");
        break;
    case 22:
        input = File.ReadAllLines("./Day22.csv");
        Console.WriteLine($"Part1: \t{Day22.ProcessPart1(input)}");
        Console.WriteLine($"Part2: \t{Day22.ProcessPart2(input)}");
        break;
    case 23:
        input = File.ReadAllLines("./Day23.csv");
        Console.WriteLine($"Part1: \t{Day23.ProcessPart1(input)}");
        Console.WriteLine($"Part2: \t{Day23.ProcessPart2(input)}");
        break;
    case 24:
        input = File.ReadAllLines("./Day24.csv");
        Console.WriteLine($"Part1: \t{Day24.ProcessPart1(input)}");
        Console.WriteLine($"Part2: \t{Day24.ProcessPart2(input)}");
        break;
    case 25:
        input = File.ReadAllLines("./Day25.csv");
        Console.WriteLine($"Part1: \t{Day25.ProcessPart1(input)}");
        Console.WriteLine($"Part2: \t{Day25.ProcessPart2(input)}");
        break;
    default:
        Console.WriteLine($"Day not found!");
        break;
}

Console.ReadLine();