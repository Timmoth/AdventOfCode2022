# [Advent Of Code 2022](https://adventofcode.com/2022)

[![csharp](https://img.shields.io/badge/--512BD4?logo=csharp&logoColor=ffffff)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![dotnet](https://img.shields.io/badge/--512BD4?logo=.net&logoColor=ffffff)](https://dotnet.microsoft.com/)

Note - I've opted for performance over tidiness in my solutions!

## Day1
|         Method |     Mean |    Error |   StdDev | Allocated |
|--------------- |---------:|---------:|---------:|----------:|
| BenchmarkPart1 | 20.56 us | 0.108 us | 0.101 us |         - |
| BenchmarkPart2 | 20.36 us | 0.198 us | 0.185 us |         - |

## Day2
|         Method |     Mean |     Error |    StdDev | Allocated |
|--------------- |---------:|----------:|----------:|----------:|
| BenchmarkPart1 | 2.809 us | 0.0138 us | 0.0129 us |         - |
| BenchmarkPart2 | 3.001 us | 0.0181 us | 0.0169 us |         - |

## Day3
|         Method |     Mean |     Error |    StdDev | Allocated |
|--------------- |---------:|----------:|----------:|----------:|
| BenchmarkPart1 | 6.450 us | 0.0590 us | 0.0493 us |         - |
| BenchmarkPart2 | 6.768 us | 0.0163 us | 0.0128 us |         - |

## Day4
|         Method |     Mean |    Error |   StdDev | Allocated |
|--------------- |---------:|---------:|---------:|----------:|
| BenchmarkPart1 | 38.67 us | 0.372 us | 0.311 us |         - |
| BenchmarkPart2 | 40.01 us | 0.480 us | 0.425 us |         - |

## Day5
|         Method |     Mean |    Error |   StdDev |   Gen0 | Allocated |
|--------------- |---------:|---------:|---------:|-------:|----------:|
| BenchmarkPart1 | 38.50 us | 0.313 us | 0.348 us | 5.2490 |  42.99 KB |
| BenchmarkPart2 | 42.06 us | 0.620 us | 0.550 us | 6.9580 |  56.98 KB |

## Day 6
|         Method |     Mean |    Error |   StdDev |   Gen0 | Allocated |
|--------------- |---------:|---------:|---------:|-------:|----------:|
| BenchmarkPart1 | 38.56 us | 0.726 us | 0.865 us | 5.2490 |  42.99 KB |
| BenchmarkPart2 | 39.58 us | 0.209 us | 0.164 us | 6.9580 |  56.98 KB |

## Day 7
|         Method |     Mean |    Error |   StdDev |    Gen0 |   Gen1 | Allocated |
|--------------- |---------:|---------:|---------:|--------:|-------:|----------:|
| BenchmarkPart1 | 43.38 us | 0.815 us | 0.762 us | 15.1367 | 4.3335 | 123.75 KB |
| BenchmarkPart2 | 48.58 us | 0.852 us | 0.797 us | 15.3198 | 4.3335 | 125.38 KB |

## Day 8
|         Method |       Mean |   Error |  StdDev |    Gen0 |    Gen1 | Allocated |
|--------------- |-----------:|--------:|--------:|--------:|--------:|----------:|
| BenchmarkPart1 |   288.1 us | 3.63 us | 3.40 us | 82.0313 | 58.1055 | 673.26 KB |
| BenchmarkPart2 | 1,468.2 us | 6.27 us | 5.87 us | 80.0781 | 50.7813 | 664.35 KB |

## Day9
|         Method |     Mean |   Error |  StdDev |    Gen0 |    Gen1 |    Gen2 | Allocated |
|--------------- |---------:|--------:|--------:|--------:|--------:|--------:|----------:|
| BenchmarkPart1 | 464.2 us | 5.07 us | 4.24 us | 41.5039 | 41.5039 | 41.5039 | 364.92 KB |
| BenchmarkPart2 | 614.2 us | 5.86 us | 5.19 us | 23.4375 |  6.8359 |       - | 200.52 KB |

## Day10
|         Method |     Mean |     Error |    StdDev |   Gen0 | Allocated |
|--------------- |---------:|----------:|----------:|-------:|----------:|
| BenchmarkPart1 | 1.082 us | 0.0063 us | 0.0056 us |      - |         - |
| BenchmarkPart2 | 1.483 us | 0.0059 us | 0.0055 us | 0.1659 |    1400 B |
