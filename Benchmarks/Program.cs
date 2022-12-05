﻿using BenchmarkDotNet.Running;

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
    case -1:
        BenchmarkRunner.Run<Day1Benchmarks>();
        BenchmarkRunner.Run<Day2Benchmarks>();
        BenchmarkRunner.Run<Day3Benchmarks>();
        BenchmarkRunner.Run<Day4Benchmarks>();
        BenchmarkRunner.Run<Day5Benchmarks>();
        break;
}

Console.ReadLine();