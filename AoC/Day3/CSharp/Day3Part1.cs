using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace AoC.Day3.CSharp;

public class Day3Part1 : IDay
{
    private string _input = "";
    private const string Pattern = @"mul\(([0-9]*),([0-9]*)\)";
    private readonly List<int> _inputList = [];
    
    public void Run()
    {
        HandleInput("../../../Day3/input.txt");
        FindResults();
    }

    public void HandleInput(string path)
    {
        _input = File.ReadAllText(path);
    }

    private void FindResults()
    {
        var res = 0;

        try
        {
            var matches = Regex.Matches(_input, Pattern);
            foreach (Match match in matches)
            {
                _inputList.Add((int.Parse(match.Groups[1].Value)) * (int.Parse(match.Groups[2].Value)));
            }

            res += _inputList.Sum();

            Console.WriteLine($"C# | Day 3, Part 1 | Sum: {res}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Woops - No Input file? Err: {e}");
            throw;
        }
    }
}