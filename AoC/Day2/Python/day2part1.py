reports = open("AoC/Day2/input.txt", "r").read().splitlines()


def run():
    """How many reports are safe?"""
    cleaned = []
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
                break

            # Check if Increasing / Decreasing
            if int(level[i]) > int(level[i + 1]):
                increasing -= 1
            else:
                increasing += 1

        if abs(increasing) == abs(len(level) - 1):
            safe = True
        else:
            safe = False

        increasing = 0
        if safe:
            safe_amount += 1
    print(f"Py | Day 2, Part 1 | Safe amount: {safe_amount}")
