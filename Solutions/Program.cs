﻿Console.Write("Select a day to run: ");
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
}

Console.ReadLine();