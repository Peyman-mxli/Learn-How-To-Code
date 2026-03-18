"""
====================================================
📘 CLI CALCULATOR
📁 MAIN APPLICATION
====================================================

This program is a command-line calculator that allows
users to perform basic arithmetic operations.

Features:
✔ Addition
✔ Subtraction
✔ Multiplication
✔ Division
✔ Continuous execution (loop)
✔ Input validation
"""
# ====================================================
# FUNCTIONS (OPERATIONS)
# ====================================================

def add(a, b):
    return a + b

def subtract(a, b):
    return a - b

def multiply(a, b):
    return a * b

def divide(a, b):
    if b == 0:
        return "Error: Division by zero"
    return a / b

# ====================================================
# MAIN PROGRAM LOOP
# ====================================================

while True:
    print("\n==============================")
    print("      CLI CALCULATOR")
    print("==============================")
    print("1. Addition")
    print("2. Subtraction")
    print("3. Multiplication")
    print("4. Division")
    print("5. Exit")
    print("==============================")

    choice = input("Select an option (1-5): ")

    # EXIT CONDITION
    if choice == "5":
        print("Exiting calculator...")
        break

    # VALIDATION FOR OPERATION
    if choice not in ["1", "2", "3", "4"]:
        print("Invalid choice. Please select a valid option.")
        continue

    # INPUT NUMBERS WITH VALIDATION
    try:
        num1 = float(input("Enter first number: "))
        num2 = float(input("Enter second number: "))
    except ValueError:
        print("Invalid input. Please enter numeric values.")
        continue

    # PERFORM OPERATION
    if choice == "1":
        result = add(num1, num2)
    elif choice == "2":
        result = subtract(num1, num2)
    elif choice == "3":
        result = multiply(num1, num2)
    elif choice == "4":
        result = divide(num1, num2)

    # DISPLAY RESULT
    print("Result:", result)

# ====================================================
# END OF PROGRAM
# ====================================================
===========================================================================
👤 Author
===========================================================================

Peyman Miyandashti
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161

===========================================================================
