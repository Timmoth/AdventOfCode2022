using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day8Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./Day8.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day8.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day8.ProcessPart2(input);
    }
}