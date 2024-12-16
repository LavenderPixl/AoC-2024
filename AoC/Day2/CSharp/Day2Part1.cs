namespace AoC.Day2.CSharp;

public class Day2Part1
{
    private List<List<int>> workingList { get; set; }
    public Day2Part1(bool partOne)
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
        
        int safeAmount = 0;
        int increasing = 0;
        CleanList();
    }

    private void CheckingList()
    {
        
    }
    
    private List<List<int>> CleanList()
    {
        // Seperated by Levels.
        var input = File.ReadAllText("../../../Day2/input.txt").Split("\n");
        var cleaned = new List<List<int>>();
        var temp = new List<int>();

        //Report
        foreach (var report in input)
        {
            //Level
            var levels = report.Split(" ");
            foreach (var level in levels)
            {
                temp.Add(int.Parse(level));
            }

            cleaned.Add(temp);
            temp = [];
        }

        return cleaned;
        // foreach (var VARIABLE in cleaned)
        // {
        // Console.WriteLine(String.Join(";", VARIABLE));
        // }
        // Console.WriteLine(temp.);
    }
}