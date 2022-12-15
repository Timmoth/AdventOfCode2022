using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Xunit.Abstractions;

public static class Day15
{
    public static ITestOutputHelper? TestOutput { get; set; } = null;

    public static int ProcessPart1(string[] input, int yPos)
    {
        var (sensors, minX, maxX) = ParseInput(input);

        var visibleXPositions = new Dictionary<int, bool>();
        for(int i = minX; i < maxX; i++)
        {
            visibleXPositions[i] = true;
        }

        var output = 0;
        for(int i = 0; i < sensors.Length; i++)
        {
            var sensor = sensors[i];
            if (!sensor.Overlaps(yPos))
            {
                // sensor reading does not overlap given horizontal line
                continue;
            }

            if (sensor.BeaconY == yPos)
            {
                // Beacon on line does not count
                visibleXPositions.Remove(sensor.BeaconX);
            }

            for (int x = sensor.X - sensor.Range; x <= sensor.X + sensor.Range; x++)
            {
                if (sensor.CanReach(x, yPos) && visibleXPositions.Remove(x))
                {
                    // One more point that could not be a beacon
                    output++;
                }
            }
        }

        return output;
    }

    public static long ProcessPart2(string[] input, int maxCoord)
    {
        var (sensors, minX, maxX) = ParseInput(input);

        for (int i = 0; i < sensors.Length; i++)
        {
            var sensor = sensors[i];
            var edgeDistance = sensor.Range + 1;
            var min = Math.Max(sensor.X - edgeDistance, 0);
            var max = Math.Min(sensor.X + edgeDistance, maxCoord);

            for (int j = min; j < sensor.X; j++)
            {
                int y1 = sensor.Y + (edgeDistance - (j - min));
                if(y1 >= 0 && y1 <= maxCoord && !sensors.Any(s =>s.CanReach(j, y1)))
                {
                    return GetOutput(j, y1);
                }

                int y2 = sensor.Y - (edgeDistance - (j - min));
                if (y2 >= 0 && y2 <= maxCoord && !sensors.Any(s => s.CanReach(j, y2)))
                {
                    return GetOutput(j, y2);
                }
            }

            var x = sensor.X;
            var y = sensor.Y + edgeDistance;
            if (y >= 0 && y <= maxCoord && !sensors.Any(s => s.CanReach(x, y)))
            {
                return GetOutput(x, y);
            }

            x = sensor.X;
            y = sensor.Y - edgeDistance;
            if (y >= 0 && y <= maxCoord && !sensors.Any(s => s.CanReach(x, y)))
            {
                return GetOutput(x, y);
            }

            for (int j = sensor.X + 1; j <= max; j++)
            {
                int y1 = sensor.Y + (edgeDistance - (j - sensor.X));
                if (y1 >= 0 && y1 <= maxCoord && !sensors.Any(s => s.CanReach(j, y1)))
                {
                    return GetOutput(j, y1);
                }

                int y2 = sensor.Y - (edgeDistance - (j - sensor.X));
                if (y2 >= 0 && y2 <= maxCoord && !sensors.Any(s => s.CanReach(j, y2)))
                {
                    return GetOutput(j, y2);
                }
            }
        }

        return 0;
    }
    public static (Sensor[] sensors, int minX, int maxX) ParseInput(string[] input)
    {
        var sensors = new Sensor[input.Length];

        var minX = 0;
        var maxX = 0;


        for (var i = 0; i < input.Length; i++)
        {
            var line = input[i].AsSpan();
            var lineIndex = 12;
            var sensorX = line.ParseIntAtPosition(ref lineIndex, ',');
            lineIndex += 3;// Skip ' y='
            var sensorY = line.ParseIntAtPosition(ref lineIndex, ':');
            lineIndex += 24;//Skip  'closest beacon is at x='
            var beaconX = line.ParseIntAtPosition(ref lineIndex, ',');
            lineIndex += 3;// Skip ' y='
            var beaconY = int.Parse(line[lineIndex..]);

            var sensor = sensors[i] = new Sensor()
            {
                X = sensorX,
                Y = sensorY,
            };

            sensor.SetBeacon(beaconX, beaconY);

            minX = Math.Min(sensor.X - sensor.Range, minX);
            maxX = Math.Max(sensor.X + sensor.Range, maxX);
        }

        return (sensors, minX, maxX);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long GetOutput(long x, long y) => 4000000 * x + y;
    public class Sensor
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Range { get; private set; }
        public int BeaconX { get; set; }
        public int BeaconY { get; set; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsBeaconAt(int x, int y)
        {
            return x == BeaconX && y == BeaconY;
        }
        public void SetBeacon(int x, int y)
        {
            BeaconX = x; 
            BeaconY = y;
            Range = Math.Abs(X - BeaconX) + Math.Abs(Y - BeaconY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool CanReach(int x, int y)
        {
            return Math.Abs(X - x) + Math.Abs(Y - y) <= Range;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool CanReach(Sensor other)
        {
            return Math.Abs(X - other.X) + Math.Abs(Y - other.Y) <= Range + other.Range + 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Overlaps(int y)
        {
            return Math.Abs(Y - y) <= Range;
        }
    }
}