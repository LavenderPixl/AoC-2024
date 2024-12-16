namespace AoC.Day2.CSharp;

///How many reports are safe?
public class Day2Part1 : IDay
{
    private List<List<int>> _workingList = [];

    public void Run()
    {
        HandleInput("../../../Day2/input.txt");
        //Remove Lists/Levels from Main list, where values increase/decrease too much.
        _workingList = CheckDifferenceOfValues();
    }

    public void HandleInput(string path)
    {
        var input = File.ReadAllText(path).Split("\n");

        foreach (var report in input)
        {
            var levels = report.Split(" ");
            var cleaned = levels.Select(int.Parse).ToList();

            _workingList.Add(cleaned);
        }
    }

    private List<List<int>> CheckDifferenceOfValues()
    {
        List<List<int>> cleaned = [];

        foreach (var li in _workingList)
        {
            var clean = false;
            int? previous = null;
            var endIndex = li.Count - 1;
            int increase = 0;
            foreach (var level in li)
            {
                //If first index/level, skip, to set current as previous.
                if (previous != null)
                {
                    //Checking difference for each int in level.
                    //If Incorrect levels, break.
                    if (Math.Abs(level - previous.Value) < 1 | Math.Abs(level - previous.Value) > 3)
                    {
                        clean = false;
                        break;
                    }

                    if (previous > level)
                    {
                        increase++;
                    }
                    else
                    {
                        increase--;
                    }

                    clean = true;
                }

                previous = level;
            }

            if (!clean || Math.Abs(increase) < endIndex || Math.Abs(increase) > endIndex)
            {
                continue;
            }

            cleaned.Add(li);
        }

        Console.WriteLine($"C# | Day 2, Part 1 | Cleaned: {cleaned.Count}");
        return cleaned;
    }
}