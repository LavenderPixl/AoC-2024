# Need to check if:
#    The levels are either all increasing or all decreasing.
#    Any two adjacent levels differ by at least one and at most three.

reports = open("AoC/Day2/input.txt", "r").read().splitlines()

def part_one():
    cleaned = []
    safe = True
    safe_amount = 0
    increasing = 0
    for levels in reports:
        cleaned.append(levels.split(" "))

    for level in cleaned:
        last_index = len(level) - 1
        for i in range(len(level)):
            if i == last_index:
                continue    

            # Checking difference of index and one after.
            difference = abs(int(level[i]) - int(level[i + 1]))

            if difference > 3 or difference < 1:
                safe = False
                break

            # Check if Increasing / Decreasing
            if int(level[i]) > int(level[i + 1]):
                increasing -= 1
            else:
                increasing += 1


        # print(abs(len(level) - 1), abs(increasing))
        if abs(increasing) == abs(len(level) - 1):
            safe = True
            # print(f"Safe: {safe}")
        else:
            safe = False

        increasing = 0
        if safe:
            safe_amount += 1
            safe = False
    print(f"Safe amount: {safe_amount}")

part_one()
