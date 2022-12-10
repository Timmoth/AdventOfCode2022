using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day10Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./Day10.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day10.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day10.ProcessPart2(input);
    }
}