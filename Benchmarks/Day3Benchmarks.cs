using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day3Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./day3.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day3.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day3.ProcessPart2(input);
    }
}