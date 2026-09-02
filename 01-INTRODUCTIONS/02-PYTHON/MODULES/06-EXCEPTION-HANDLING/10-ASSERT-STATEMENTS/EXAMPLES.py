"""
Module — Assert Statements

Runnable examples showing how assertions can protect internal program assumptions.
"""


print("\nExample 1 — Simple assertion")
age = 18
assert age >= 0
print("Age is valid")


print("\nExample 2 — Assertion with custom message")
temperature = -300

try:
    assert temperature >= -273.15, "Temperature below absolute zero!"
except AssertionError as error:
    print("Assertion error:", error)


print("\nExample 3 — Assertion inside a function")

def calculate_average(numbers):
    assert len(numbers) > 0, "List must not be empty"
    return sum(numbers) / len(numbers)


try:
    result = calculate_average([10, 20, 30])
    print("Average:", result)
except AssertionError as error:
    print("Assertion error:", error)


print("\nExample 4 — Function preconditions")

def withdraw(balance, amount):
    assert amount >= 0, "Withdrawal amount must be positive"
    assert balance >= amount, "Insufficient funds"
    return balance - amount


try:
    remaining = withdraw(1000, 250)
    print("Remaining balance:", remaining)
except AssertionError as error:
    print("Assertion error:", error)
