using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day18Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./Day18.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day18.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day18.ProcessPart2(input);
    }
}