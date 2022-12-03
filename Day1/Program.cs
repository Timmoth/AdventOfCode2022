
var input = File.ReadAllLines("./day1.csv");
var mostCaloriesCarried = Day1.GetMostCaloriesCarried(input);
Console.WriteLine(mostCaloriesCarried);
Console.Read();

public static class Day1
{
    public static int GetMostCaloriesCarried(string[] input)
    {
        int mostCaloriesCarried = 0;
        int currentCaloriesCounted = 0;
        Span<string> inputAsSpan = input;
        for(int i = 0; i < inputAsSpan.Length; i++)
        {
            var line = inputAsSpan[i];
            if (string.IsNullOrEmpty(line))
            {
                if(mostCaloriesCarried < currentCaloriesCounted)
                {
                    mostCaloriesCarried = currentCaloriesCounted;
                }
                currentCaloriesCounted = 0;
                continue;
            }

            currentCaloriesCounted += int.Parse(line);
        }

        if (currentCaloriesCounted > mostCaloriesCarried)
        {
            return currentCaloriesCounted;
        }

        return mostCaloriesCarried;
    }
}
