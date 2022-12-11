using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day11Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./Day11.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day11.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day11.ProcessPart2(input);
    }
}