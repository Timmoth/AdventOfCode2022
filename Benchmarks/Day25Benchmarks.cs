using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day25Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./Day25.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day25.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day25.ProcessPart2(input);
    }
}