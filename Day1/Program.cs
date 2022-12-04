
var input = File.ReadAllLines("./day1.csv");
var output = Day1.Process(input);
Console.WriteLine($"Most calories carried by one elf: \t{output.mostCaloriesCountedByOneElf}");
Console.WriteLine($"Most calories carried by three elfs: \t{output.mostCaloriesCountedByThreeElfs}");
Console.Read();

public static class Day1
{
    private static void Update(this ref (int first, int second, int third) topCaloriesCarried, int caloriesCarried)
    {
        if (topCaloriesCarried.first < caloriesCarried)
        {
            topCaloriesCarried.third = topCaloriesCarried.second;
            topCaloriesCarried.second = topCaloriesCarried.first;
            topCaloriesCarried.first = caloriesCarried;
        }
        else if (topCaloriesCarried.second < caloriesCarried)
        {
            topCaloriesCarried.third = topCaloriesCarried.second;
            topCaloriesCarried.second = caloriesCarried;
        }
        else if (topCaloriesCarried.third < caloriesCarried)
        {
            topCaloriesCarried.third = caloriesCarried;
        }
    }
    public static (int mostCaloriesCountedByOneElf, int mostCaloriesCountedByThreeElfs) Process(string[] input)
    {
        (int first, int second, int third) answer = (0, 0, 0);

        int currentCaloriesCounted = 0;
        Span<string> inputAsSpan = input;
        for(int i = 0; i < inputAsSpan.Length; i++)
        {
            var line = inputAsSpan[i];
            if (string.IsNullOrEmpty(line))
            {
                answer.Update(currentCaloriesCounted);
                currentCaloriesCounted = 0;
                continue;
            }

            currentCaloriesCounted += int.Parse(line);
        }

        answer.Update(currentCaloriesCounted);

        return (answer.first, answer.first + answer.second + answer.third);
    }
}
