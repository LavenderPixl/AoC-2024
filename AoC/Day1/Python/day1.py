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


def fin():
    first, second = sort()
    new_list = []
    counter = 0

    # Checking which side is bigger, and then subtracting the smaller number from the bigger.
    for i in first:
        new_list.append(abs((int(first[counter]) - (int(second[counter])))))
        counter = counter + 1

    print(sum(new_list))


fin()
