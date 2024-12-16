from AoC.Day1.Python import day1part1

def run():
    first, second = day1part1.sort()
    resulting_list = []
    for i in first:
        amount = 0
        for u in second:
            if i == u:
                amount += 1
        if amount > 0:
            resulting_list.append([i, amount])

    result = 0
    for number in resulting_list:
        result += (int(number[0]) * number[1])
    print(f"Py | Day 1, Part 2 | Result: {result}")
