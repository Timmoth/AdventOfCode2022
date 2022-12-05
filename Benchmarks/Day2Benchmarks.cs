using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day2Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./day2.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day2.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day2.ProcessPart2(input);
    }

}