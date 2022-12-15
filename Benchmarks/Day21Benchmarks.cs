using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day21Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./Day21.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day21.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day21.ProcessPart2(input);
    }
}