using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day7Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./Day7.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day7.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day7.ProcessPart2(input);
    }
}