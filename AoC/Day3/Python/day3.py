import re

reports = open("AoC/Day3/input.txt", "r").read().splitlines()
pattern = re.compile(r'mul\(([0-9]*),([0-9]*)\)')


def part_one():
    matches = []
    result = 0
    for report in reports:
        for (a, b) in re.findall(pattern, report):
            matches.append(int(a) * int(b))

    for r in matches:
        result += r

    print(result)

part_one()