# Maybe later...Ugh



def run():
    print("Py | Day 4, Part 1 | Not ready yet.")
    # cleaned_list = clean_data()
    # crawl_data(cleaned_list)
#
#
# def clean_data():
#     cleaned_list = []
#     data = open("AoC/Day4/input.txt", "r").read().splitlines()
#     line = 0
#     for letters in data:
#         index = 0
#         for letter in letters:
#             cleaned_list.append((letter, index, line))
#             index += 1
#         line += 1
#     return cleaned_list
#
#
# def crawl_data(cleaned_list):
#     res = 0
#     word = ["X", "M", "A", "S"]
#     word_pos = 0
#     line_pos = 0
#
#     for letter, index, line in cleaned_list:
#         # print(letter, index, line)
#
#         # Found a full word
#         if word_pos == len(word):
#             res += 1
#             word_pos = 0
#
#         side_res = check_sides(letter, word, word_pos)
#         match side_res:
#             case "Full":
#                 res += 1
#                 word_pos = 0
#                 continue
#             case "Redo":
#                 check_sides(letter, word, word_pos)
#                 word_pos += 1
#
#                 # while redo == "Redo":
#                 #     word_pos += 1
#                 #     check_sides(letter, word, word_pos)
#                 #     if redo == "Full":
#                 #         res += 1
#                 #         word_pos = 0
#                 #         continue
#                 #     if redo == "None":
#                 #         word_pos = 0
#                 #         continue
#             case "None":
#                 word_pos = 0
#                 continue
#     print(res)
#
# def check_sides(letter, word, word_pos):
#     # Found a full word
#     if word_pos == len(word):
#         return "Full"
#     # Found correct letter
#     if letter == word[word_pos] or letter == word[::-1][word_pos]:
#         return "Redo"
#     else:
#         # Checking if next index is start of new result or not.
#         word_pos = 0
#         if letter == word[word_pos] or letter == word[::-1][word_pos]:
#             word_pos += 1
#         else:
#             return "None"
#
# # def check_top_bottom():
# # def check_diagonal():
#
#
# # def crawl_data(cleaned_list):
# #     res = 0
# #     word = ["X", "M", "A", "S"]
# #     # print(word[::-1])
# #     word_pos = 0
# #     # line_pos = 0
# #     for letter, index, line in cleaned_list:
# #         # print(letter, index, line)
# #         if word_pos == len(word):
# #             res += 1
# #             word_pos = 0
# #         if letter == word[word_pos] or letter == word[::-1][word_pos]:
# #             # check_diagonal(letter, index, line, word, word_pos)
# #             check_down(letter, index, line, word, word_pos, cleaned_list)
# #             check_up(letter, index, line, word, word_pos)
# #             word_pos += 1
# #             continue
# #         else:
# #             #Checking if next index is start of new result or not.
# #             word_pos = 0
# #             if letter == word[word_pos] or letter == word[::-1][word_pos]:
# #                 word_pos += 1
# #                 continue
# #     print(res)
# #
# #
# # def check_down(letter, index, line, word, word_pos, cleaned_list):
# #     if word_pos == len(word):
# #         return True
# #     if letter[index, line + 1] == word[word_pos]:
# #         word_pos += 1
# #         line += 1
# #     check_down(letter, index, line, word, word_pos, cleaned_list)
# #
# # def check_up(letter, index, line, word, word_pos):
# #     if word_pos == len(word):
# #         return True
# #     if line == 0:
# #         return False
# #
# #     if letter[index, line - 1] == word[word_pos]:
# #         word_pos += 1
# #         line -= 1
# #         check_up(letter, index, line, word, word_pos)
# #         redo = True
# #     else:
# #         redo = False
# #
# #     if redo:
# #         check_up(letter, index, line, word, word_pos)
# #     else:
# #         if word_pos == len(word):
# #             return True
# #         else:
# #             return False
