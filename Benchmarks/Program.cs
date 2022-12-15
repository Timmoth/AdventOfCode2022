using BenchmarkDotNet.Running;

Console.Write("Select day to benchmark: ");
if(!int.TryParse(Console.ReadLine(), out var selection))
{
    Console.Write("Could not parse given day.");
}
switch (selection)
{
    case 1:
        BenchmarkRunner.Run<Day1Benchmarks>();
        break;
    case 2:
        BenchmarkRunner.Run<Day2Benchmarks>();
        break;
    case 3:
        BenchmarkRunner.Run<Day3Benchmarks>();
        break;
    case 4:
        BenchmarkRunner.Run<Day4Benchmarks>();
        break;
    case 5:
        BenchmarkRunner.Run<Day5Benchmarks>();
        break;
    case 6:
        BenchmarkRunner.Run<Day6Benchmarks>();
        break;
    case 7:
        BenchmarkRunner.Run<Day7Benchmarks>();
        break;  
    case 8:
        BenchmarkRunner.Run<Day8Benchmarks>();
        break;
    case 9:
        BenchmarkRunner.Run<Day9Benchmarks>();
        break;
    case 10:
        BenchmarkRunner.Run<Day10Benchmarks>();
        break;
    case 11:
        BenchmarkRunner.Run<Day11Benchmarks>();
        break;
    case 12:
        BenchmarkRunner.Run<Day12Benchmarks>();
        break;
    case 13:
        BenchmarkRunner.Run<Day13Benchmarks>();
        break;
    case 14:
        BenchmarkRunner.Run<Day14Benchmarks>();
        break;
    case 15:
        BenchmarkRunner.Run<Day15Benchmarks>();
        break;
    case 16:
        BenchmarkRunner.Run<Day16Benchmarks>();
        break;
    case 17:
        BenchmarkRunner.Run<Day17Benchmarks>();
        break;
    case 18:
        BenchmarkRunner.Run<Day18Benchmarks>();
        break;
    case 19:
        BenchmarkRunner.Run<Day19Benchmarks>();
        break;
    case 20:
        BenchmarkRunner.Run<Day20Benchmarks>();
        break;
    case 21:
        BenchmarkRunner.Run<Day21Benchmarks>();
        break;
    case 22:
        BenchmarkRunner.Run<Day22Benchmarks>();
        break;
    case 23:
        BenchmarkRunner.Run<Day23Benchmarks>();
        break;
    case 24:
        BenchmarkRunner.Run<Day24Benchmarks>();
        break;
    case 25:
        BenchmarkRunner.Run<Day25Benchmarks>();
        break;
    case -1:
        BenchmarkRunner.Run<Day1Benchmarks>();
        BenchmarkRunner.Run<Day2Benchmarks>();
        BenchmarkRunner.Run<Day3Benchmarks>();
        BenchmarkRunner.Run<Day4Benchmarks>();
        BenchmarkRunner.Run<Day5Benchmarks>();
        BenchmarkRunner.Run<Day6Benchmarks>();
        BenchmarkRunner.Run<Day7Benchmarks>();
        BenchmarkRunner.Run<Day8Benchmarks>();
        BenchmarkRunner.Run<Day9Benchmarks>();
        BenchmarkRunner.Run<Day10Benchmarks>();
        BenchmarkRunner.Run<Day11Benchmarks>();
        BenchmarkRunner.Run<Day12Benchmarks>();
        BenchmarkRunner.Run<Day13Benchmarks>();
        BenchmarkRunner.Run<Day14Benchmarks>();
        BenchmarkRunner.Run<Day15Benchmarks>();
        BenchmarkRunner.Run<Day16Benchmarks>();
        BenchmarkRunner.Run<Day17Benchmarks>();
        BenchmarkRunner.Run<Day18Benchmarks>();
        BenchmarkRunner.Run<Day19Benchmarks>();
        BenchmarkRunner.Run<Day20Benchmarks>();
        BenchmarkRunner.Run<Day21Benchmarks>();
        BenchmarkRunner.Run<Day22Benchmarks>();
        BenchmarkRunner.Run<Day23Benchmarks>();
        BenchmarkRunner.Run<Day24Benchmarks>();
        BenchmarkRunner.Run<Day25Benchmarks>();
        break;
}

Console.ReadLine();