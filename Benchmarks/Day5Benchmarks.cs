using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day5Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./day5.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day5.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day5.ProcessPart2(input);
    }
}