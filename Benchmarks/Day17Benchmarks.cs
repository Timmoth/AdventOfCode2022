using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day17Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./Day17.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day17.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day17.ProcessPart2(input);
    }
}