using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day14Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./Day14.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day14.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day14.ProcessPart2(input);
    }
}