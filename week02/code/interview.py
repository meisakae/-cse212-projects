"""
Problem: Reverse a String

Given a string, return a new string with the characters in reverse order.

Example:
reverse_string("hello") -> "olleh"
reverse_string("Interview") -> "weivretnI"
"""


def reverse_string(s):
    result = ""

    for n in s:
        result = n + result
    return result

# Write your solution here.
pass


# Test cases
print(reverse_string("hello")) # expected: "olleh"
print(reverse_string("Interview")) # expected: "weivretnI"
print(reverse_string("")) # expected: ""
print(reverse_string("a")) # expected: "a"
