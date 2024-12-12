using System.Text.RegularExpressions;

namespace AoC.Day3.CSharp;

public class Day3
{
    public Day3(bool partOne)
    {
        if (partOne)
        {
            //- Part One. - What do you get if you add up all the results of the multiplications?
            PartOne();
        }
        else
        {
            //- Part Two. - What do you get if you add up all of the results of just the enabled multiplications?
            // PartTwo(); 
        }
    }

    private void PartOne()
    {
        var input = File.ReadAllText("../../../Day3/input.txt");
        var inputList = new List<int>();

        const string pattern = @"mul\(([0-9]*),([0-9]*)\)";
        int res = 0;

        try
        {
            var matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                inputList.Add((int.Parse(match.Groups[1].Value)) * (int.Parse(match.Groups[2].Value)));
            }
            
            foreach (var i in inputList)
            {
                res += i;
            }

            Console.WriteLine(res);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Woops - No Input file? Err: {e}");
            throw;
        }
    }
}