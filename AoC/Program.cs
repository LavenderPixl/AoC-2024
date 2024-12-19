using System.Threading.Channels;
using AoC.Day1.CSharp;
using AoC.Day2.CSharp;
using AoC.Day3.CSharp;

namespace AoC;

class Program
{
    static void Main(string[] args)
    {
        bool redo;
        do
        {
            RunDay();
            redo = ReDo();
        } while (redo);

        void RunDay()
        {
            Console.Clear();
            Console.WriteLine("Which day would you like to see? \n- 1-3 for a specific day\n- * for all days.");
            var reply = Console.ReadLine();

            Day1Part1 day1Part1 = new();
            Day1Part2 day1Part2 = new();
            Day2Part1 day2Part1 = new();
            Day3Part1 day3Part1 = new();
            switch (reply)
            {
                case "1":
                    //Day 1
                    day1Part1.Run();
                    day1Part2.Run();
                    break;
                case "2":
                    //Day 2
                    day2Part1.Run();
                    break;
                case "3":
                    //Day 3
                    day3Part1.Run();
                    break;
                case "*":
                    day1Part1.Run();
                    day1Part2.Run();
                    day2Part1.Run();
                    day3Part1.Run();
                    break;
                default:
                    Console.WriteLine("That's not a valid input.");
                    break;
            }
        }

        bool ReDo()
        {
            bool userInput;
            Console.WriteLine("Would you like to retry again? Y/N");
            var reply = Console.ReadLine();
            reply = reply?.ToLower();

            switch (reply)
            {
                case "y":
                    userInput = true;
                    break;
                case "n" :
                    userInput = false;
                    break;
                default:
                    Console.WriteLine("Incorrect Input.");
                    userInput = true;
                    break;
            }

            return userInput;
        }
    }
}