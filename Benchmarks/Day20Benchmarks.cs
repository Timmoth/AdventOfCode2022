using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day20Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./Day20.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day20.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day20.ProcessPart2(input);
    }
}