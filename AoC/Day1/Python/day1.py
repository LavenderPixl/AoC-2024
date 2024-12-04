def sort():
    first_line = []
    second_line = []

    content = open("AoC/Day1/input.txt", "r").read().splitlines()
    # Sorting lines.
    for line in content:
        first_line.append(line.split()[0])
        second_line.append(line.split()[1])

    first_line.sort()
    second_line.sort()
    return first_line, second_line


def part_one():
    first, second = sort()
    new_list = []
    counter = 0

    # Checking which side is bigger, and then subtracting the smaller number from the bigger.
    for i in first:
        new_list.append(abs((int(first[counter]) - (int(second[counter])))))
        counter += 1

    print(sum(new_list))


def part_two():
    first, second = sort()
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
    print(result)

# partOne()
part_two()
