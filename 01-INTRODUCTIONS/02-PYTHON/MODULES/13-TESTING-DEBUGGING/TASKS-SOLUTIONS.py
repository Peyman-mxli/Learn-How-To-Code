"""
Module — Testing & Debugging — Reference Solutions
"""


def say_hello():
    print("Hello World")


def add_numbers(a, b):
    return a + b


def divide(a, b):
    try:
        return a / b
    except ZeroDivisionError:
        return "Error: Cannot divide by zero"


def calculate_average(a, b):
    return (a + b) / 2


def is_even(number):
    return number % 2 == 0


def calculate_total(price, quantity):
    total = price * quantity
    print("Price:", price)
    print("Quantity:", quantity)
    print("Calculated total:", total)
    return total


def convert_to_int(value):
    try:
        return int(value)
    except ValueError:
        return "Error: Invalid integer value"


def calculate_invoice(price, quantity):
    assert price > 0, "Price must be greater than zero"
    assert quantity > 0, "Quantity must be positive"
    return price * quantity


def get_percentage(value, total):
    try:
        if total == 0:
            return "Error: Total cannot be zero"
        return (value / total) * 100
    except TypeError:
        return "Error: Invalid data types"


def get_max_value(numbers):
    if not numbers:
        return "Error: List is empty"
    return max(numbers)


if __name__ == "__main__":
    say_hello()
    print("Result:", add_numbers(5, 7))
    print(divide(10, 2))
    print(divide(10, 0))
    print("Average:", calculate_average(10, 20))
    print(is_even(4))
    calculate_total(50, 3)
    print(convert_to_int("123"))
    print(calculate_invoice(100, 2))
    print(get_percentage(50, 200))
    print(get_max_value([3, 7, 2, 9]))
