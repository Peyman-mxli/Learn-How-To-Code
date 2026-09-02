"""
Module — Assert Statements — Reference Solutions
"""

# Rank 1
number = 5
assert number > 0
print("Number is valid")

# Rank 2
text = "Python"
assert len(text) > 0
print("Text is valid")

# Rank 3

def first_element(items):
    assert len(items) > 0, "List cannot be empty"
    return items[0]


print("First element:", first_element([1, 2, 3]))


# Rank 4

def divide(a, b):
    assert isinstance(a, (int, float)), "a must be a number"
    assert isinstance(b, (int, float)), "b must be a number"
    assert b != 0, "Divider must not be zero"
    return a / b


print("Division result:", divide(10, 2))


# Rank 5

def process_score(score):
    assert 0 <= score <= 100, "Score must be between 0 and 100"
    return "Pass" if score >= 60 else "Fail"


print("Result:", process_score(75))
