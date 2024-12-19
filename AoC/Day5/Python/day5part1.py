def run():
    rules, updates = clean_data()
    print(f"Py | Day 5, Part 1 | Correct updates: {do_stuff(rules, updates)}")


def clean_data():
    cleaned_rules = []
    cleaned_updates = []
    data = open("AoC/Day5/input.txt", "r").read().split("\n\n")
    rules, updates = data[0], data[1]
    rules = rules.splitlines()
    updates = updates.splitlines()
    for rule in rules:
        left, right = rule.rsplit("|", maxsplit=1)
        cleaned_rules.append((left, right))
    for update in updates:
        re = update.rsplit(",")
        cleaned_updates.append(re)

    return cleaned_rules, cleaned_updates


def check_rules(rules, updates):
    result = []
    for update in updates:
        correct = True
        for i in range(len(update)):
            for j in range(i + 1, len(update)):
                for rule in rules:
                    if update[i] in rule and update[j] in rule:
                        if update[i] == rule[0] and update[j] == rule[1]:
                            correct = True
                        else:
                            correct = False
                            break
                    if not correct:
                        break
                if not correct:
                    break
        if correct:
            result.append(update)

    return result

def do_stuff(rules, updates):
    returned_list = check_rules(rules, updates)
    result = 0
    for i_list in returned_list:
        middle_index = (len(i_list) - 1) // 2
        res = i_list[middle_index]
        result += int(res)
    return result