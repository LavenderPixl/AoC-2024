from AoC.Day1.Python.day1part1 import run as day1part1
from AoC.Day1.Python.day1part2 import run as day1part2
from AoC.Day2.Python.day2part1 import run as day2part1
from AoC.Day3.Python.day3part1 import run as day3part1
from AoC.Day4.Python.day4part1 import run as day4part1
from AoC.Day5.Python.day5part1 import run as day5part1


def run_day():
    day = input("Which day would you like to see? \n1-5 for a specific day \n* for all days.\nInput: ")
    print("\n*****")
    match day:
        case "1":
            day1part1()
            day1part2()
        case "2":
            day2part1()
        case "3":
            day3part1()
        case "4":
            day4part1()
        case "5":
            day5part1()
        case "*":
            day1part1()
            day1part2()
            day2part1()
            day3part1()
            day4part1()
            day5part1()
        case _:
            print("That's not a valid input, or day? Try again!")
            run_day()
    print("*****")

run_day()
