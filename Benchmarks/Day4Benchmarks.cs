using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Day4Benchmarks
{
    private string[] input = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        input = File.ReadAllLines("./day4.csv");
    }

    [Benchmark]
    public void BenchmarkPart1()
    {
        Day4.ProcessPart1(input);
    }

    [Benchmark]
    public void BenchmarkPart2()
    {
        Day4.ProcessPart2(input);
    }
}