using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day12Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./Day12.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day12.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day12.ProcessPart2(input);
    }
}