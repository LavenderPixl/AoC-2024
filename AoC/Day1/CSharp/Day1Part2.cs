namespace AoC.Day1.CSharp;

public class Day1Part2 : IDay
{
    private readonly List<int> _left = [];
    private readonly List<int> _right = [];

    public void Run()
    {
        HandleInput("../../../Day1/input.txt");
        PartTwo();
    }
    
    ///Gets input from file, and puts data in two _left & _right private lists.
    public void HandleInput(string path)
    {
        var input = File.ReadAllText(path);

        // Splitting into two Lists.
        foreach (var line in input.Split("\n"))
        {
            if (!string.IsNullOrWhiteSpace(line))
            {
                var values = line.Split("   ");

                _left.Add(int.Parse(values[0].Trim()));
                _right.Add(int.Parse(values[1].Trim()));
            }
        }
    }
    
    private void PartTwo()
    {
        List<int> numbers = [];
        foreach (var leftLine in _left)
        {
            numbers.AddRange(from rightLine in _right where leftLine == rightLine select leftLine);
        }

        var query = numbers.GroupBy(x => x)
            .Select(y => new { Number = y.Key, Counter = y.Count() })
            .ToList();

        var result = query.Sum(number => (number.Number * number.Counter));
        Console.WriteLine($"C# | Day 1, Part 2 | Result: {result}");
    }
}