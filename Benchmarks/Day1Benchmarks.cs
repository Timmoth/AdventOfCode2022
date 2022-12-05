using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day1Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./day1.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day1.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day1.ProcessPart2(input);
    }
}