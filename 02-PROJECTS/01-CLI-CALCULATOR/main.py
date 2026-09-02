"""Simple command-line calculator."""

from __future__ import annotations


def add(a: float, b: float) -> float:
    return a + b


def subtract(a: float, b: float) -> float:
    return a - b


def multiply(a: float, b: float) -> float:
    return a * b


def divide(a: float, b: float) -> float:
    if b == 0:
        raise ZeroDivisionError("Division by zero is not allowed.")
    return a / b


OPERATIONS = {
    "1": ("Addition", add),
    "2": ("Subtraction", subtract),
    "3": ("Multiplication", multiply),
    "4": ("Division", divide),
}


def read_number(prompt: str) -> float:
    while True:
        try:
            return float(input(prompt))
        except ValueError:
            print("Invalid number. Please try again.")


def main() -> None:
    while True:
        print("\n=== CLI CALCULATOR ===")
        for key, (name, _) in OPERATIONS.items():
            print(f"{key}. {name}")
        print("5. Exit")

        choice = input("Select an option (1-5): ").strip()

        if choice == "5":
            print("Goodbye.")
            return

        if choice not in OPERATIONS:
            print("Invalid choice.")
            continue

        first = read_number("First number: ")
        second = read_number("Second number: ")

        name, operation = OPERATIONS[choice]

        try:
            result = operation(first, second)
        except ZeroDivisionError as exc:
            print(f"Error: {exc}")
            continue

        print(f"{name} result: {result}")


if __name__ == "__main__":
    main()
