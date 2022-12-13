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
        break;
}

Console.ReadLine();