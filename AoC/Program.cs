using AoC.Day1.CSharp;
using AoC.Day2.CSharp;
using AoC.Day3.CSharp;

namespace AoC;

class Program
{
    static void Main(string[] args)
    {
        //Day 1
        Day1Part1 day1Part1 = new();
        day1Part1.Run();
        Day1Part2 day1Part2 = new();
        day1Part2.Run();

        //Day 2
        Day2Part1 day2Part1 = new();
        day2Part1.Run();

        //Day 3
        Day3Part1 day3Part1 = new();
        day3Part1.Run();
    }
}