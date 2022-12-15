using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day19Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./Day19.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day19.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day19.ProcessPart2(input);
    }
}