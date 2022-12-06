using System.Threading;
using System;

public static class Day6
{
    public static int ProcessPart1(string input)
    {
        ReadOnlySpan<char> s = input.AsSpan();
        char a = s[0];
        char b = s[1];
        char c = s[2];
        for(int i = 3; i < s.Length; i++)
        {
            var l = s[i];

            if(a != b && a != c && b != c && l != a && l != b && l != c)
            {
                return i+1;
            }

            switch (i % 3)
            {
                case 0:
                    a = l;
                    break;
                case 1:
                    b = l;
                    break;
                case 2:
                    c = l;
                    break;
            }
        }

        return -1;
    }

    public static int ProcessPart2(string input)
    {
        ReadOnlySpan<char> s = input.AsSpan();
        char[] buffer = new char[13];
        int head = 0;

        for (int i = 3; i < s.Length; i++)
        {
            var l = s[i];

            bool startOfMessage = true;
            var hash = new HashSet<char>()
            {
                l
            };

            for (int j = 0; j < 13; j++)
            {
                if (!hash.Add(buffer[j]))
                {
                    startOfMessage = false;
                    break;
                }
            }

            if (startOfMessage)
            {
                return i + 1;
            }

            buffer[head++] = l;
            head %= 13;
        }

        return -1;
    }
}
