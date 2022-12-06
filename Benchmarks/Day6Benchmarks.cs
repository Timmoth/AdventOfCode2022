using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day6Benchmarks
{
    private string input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./Day6.csv")[0];
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day6.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day6.ProcessPart2(input);
    }
}