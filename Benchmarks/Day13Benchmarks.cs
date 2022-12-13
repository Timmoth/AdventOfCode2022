using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day13Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./Day13.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day13.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day13.ProcessPart2(input);
    }
}