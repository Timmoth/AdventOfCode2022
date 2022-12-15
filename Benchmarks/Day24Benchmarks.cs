using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day24Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./Day24.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day24.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day24.ProcessPart2(input);
    }
}