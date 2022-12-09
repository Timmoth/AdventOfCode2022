using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day9Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./Day9.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day9.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day9.ProcessPart2(input);
    }
}