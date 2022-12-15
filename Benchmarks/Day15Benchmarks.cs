using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day15Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./Day15.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day15.ProcessPart1(input, 2000000);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day15.ProcessPart2(input, 4000000);
    }
}