def sort():
    first_line = []
    second_line = []

    data = open("AoC/Day1/input.txt", "r").read().splitlines()

    # Sorting lines.
    for line in data:
        first_line.append(line.split()[0])
        second_line.append(line.split()[1])

    first_line.sort()
    second_line.sort()
    return first_line, second_line


def run():
    first, second = sort()
    new_list = []
    counter = 0

    # Checking which side is bigger, and then subtracting the smaller number from the bigger.
    for i in first:
        new_list.append(abs((int(first[counter]) - (int(second[counter])))))
        counter += 1

    print(f"Py | Day 1, Part 1 | Result: {sum(new_list)}")
