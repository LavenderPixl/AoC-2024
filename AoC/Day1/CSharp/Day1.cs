using System.Collections.ObjectModel;

namespace AoC.Day1.CSharp;

public class Day1
{
    private readonly List<int> _left = [];
    private readonly List<int> _right = [];

    public Day1(bool partOne)
    {
        StuffLists();

        if (partOne)
        {
            //- Part One. - What is the Total Distance between your lists?
            PartOne();
        }
        else
        {
            //- Part Two. What is their similarity score?
            //How often numbers on left appear in right
            //multiply number by amount of times  
            //Plus results.
            HowOften();
        }
    }


    #region Part One

    private void PartOne()
    {
        int[] leftArray = QuickSort(_left.ToArray(), 0, _left.ToArray().Length - 1);
        int[] rightArray = QuickSort(_right.ToArray(), 0, _right.ToArray().Length - 1);
        Console.WriteLine(GetDifference(leftArray, rightArray));
    }


    ///Gets input from file, and puts data in two different lists, that it returns.
    private void StuffLists()
    {
        var input = File.ReadAllText("../../../Day1/input.txt");


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


    /// Sorts the two Lists (Left, right) and returns them.
    private int[] QuickSort(int[] arr, int low, int high)
    {
        var i = low;
        var j = high;
        var pivot = arr[low];

        while (i <= j)
        {
            while (arr[i] < pivot)
            {
                i++;
            }

            while (arr[j] > pivot)
            {
                j--;
            }

            if (i <= j)
            {
                (arr[i], arr[j]) = (arr[j], arr[i]);
                i++;
                j--;
            }
        }

        if (low < j)
            QuickSort(arr, low, j);
        if (i < high)
            QuickSort(arr, i, high);
        return arr;
    }


    ///Gets difference between each number in lists. (Result for Part One.)
    private int GetDifference(int[] left, int[] right)
    {
        int result = 0;
        for (int i = 0; i < left.Length; i++)
        {
            if (left[i] < right[i])
            {
                result += right[i] - left[i];
            }
            else
            {
                result += left[i] - right[i];
            }
        }

        return result;
    }

    #endregion

    #region Part Two


    private void HowOften()
    {
        
    }

    #endregion
}