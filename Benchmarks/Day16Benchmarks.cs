using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day16Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./Day16.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day16.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day16.ProcessPart2(input);
    }
}