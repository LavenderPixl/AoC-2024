namespace AoC.Day1.CSharp;

public class Listy
{
    public Listy(List<int> left, List<int> right)
    {
        Left = left;
        Right = right;
    }

    public List<int> Left { get; set; }
    public List<int> Right { get; set; }
}

public class Day1
{
    public static void DoStuff()
    {
        var splitList = ReadAll();
        Listy sortedList = Sort(splitList);
        int result = GetDifference(sortedList);
        Console.WriteLine(result);
    }

    ///Gets input from file, and puts data in two different lists, that it returns.
    private static Listy ReadAll()
    {
        var input = File.ReadAllText("../../../Day1/input.txt");
        Listy inputList = new([], []);

        // Splitting into two Lists.
        foreach (var line in input.Split("\n"))
        {
            var values = line.Split("   ");
            // Console.WriteLine(values[0]);
            inputList.Left.Add(int.Parse(values[0].Trim()));
            inputList.Right.Add(int.Parse(values[1].Trim()));
        }

        return inputList;
    }

    /// Sorts the two Lists (Left, right) and returns them.
    private static Listy Sort(Listy list)
    {
        Listy temp = new([], []);

        
        
        foreach (var leftie in list.Left.OrderBy(x => x))
        {
            temp.Left.Add(leftie);
        }

        foreach (var rightie in list.Right.OrderBy(x => x))
        {
            temp.Right.Add(rightie);
        }

        return temp;
    }

    private static int GetDifference(Listy sortedList)
    {
        int result = 0;
        for (int i = 0; i < sortedList.Left.Count; i++)
        {
            if (sortedList.Left[i] < sortedList.Right[i])
            {
                result += sortedList.Right[i] - sortedList.Left[i];
            }
            else
            {
                result += sortedList.Left[i] - sortedList.Right[i];
            }
        }

        return result;
    }
}