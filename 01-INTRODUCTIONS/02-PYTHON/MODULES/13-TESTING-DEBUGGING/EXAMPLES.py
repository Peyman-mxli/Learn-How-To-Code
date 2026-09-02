"""
Module — Testing & Debugging

Clean runnable examples of syntax fixes, runtime error handling,
logic correction, assertions, and small manual tests.
"""


def safe_divide(a, b):
    if b == 0:
        return "Cannot divide by zero"
    return a / b


def correct_discount(price):
    return price * 0.90


def correct_average(numbers):
    if not numbers:
        raise ValueError("numbers cannot be empty")
    return sum(numbers) / len(numbers)


def is_adult(age):
    return age >= 18


def safe_get_item(items, index):
    if 0 <= index < len(items):
        return items[index]
    return None


def calculate_total(price, quantity):
    return price * quantity


def withdraw(balance, amount):
    assert amount >= 0, "Amount must be positive"
    assert amount <= balance, "Insufficient funds"
    return balance - amount


def to_int(value):
    try:
        return int(value)
    except ValueError:
        return None


def add(a, b):
    return a + b


def main():
    print("safe_divide:", safe_divide(10, 2))
    print("safe_divide zero:", safe_divide(10, 0))
    print("discount:", correct_discount(100))
    print("average:", correct_average([10, 20, 30]))
    print("adult:", is_adult(18))
    print("item:", safe_get_item([1, 2, 3], 1))
    print("total:", calculate_total(10, 3))
    print("withdraw:", withdraw(1000, 200))
    print("to_int valid:", to_int("123"))
    print("to_int invalid:", to_int("abc"))
    print("add:", add(2, 3))


if __name__ == "__main__":
    main()
