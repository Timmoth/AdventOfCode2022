using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day23Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./Day23.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day23.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day23.ProcessPart2(input);
    }
}