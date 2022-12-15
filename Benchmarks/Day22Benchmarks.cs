using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day22Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./Day22.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day22.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day22.ProcessPart2(input);
    }
}