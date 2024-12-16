namespace AoC;
using AoC.Day1.CSharp;

class Program
{
    static void Main(string[] args)
    {
        Day1.CSharp.Day1Part1 day1Part1 = new();
        day1Part1.Run();
        Day1.CSharp.Day1Part2 day1Part2 = new();
        day1Part2.Run();
        
        // Day2.CSharp.Day2Part1 day2Part1 = new(File.ReadAllText("../../../Day2/input.txt").Split("\n"));
    }
}