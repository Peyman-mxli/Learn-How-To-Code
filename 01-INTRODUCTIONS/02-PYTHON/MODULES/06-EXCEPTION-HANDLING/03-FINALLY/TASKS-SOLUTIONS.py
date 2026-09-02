"""
Module — Exception Handling — finally

Reference solutions for the finally practice tasks.
"""

print("\nRank 1 — Solution")
try:
    print("Start")
finally:
    print("End")

print("\nRank 2 — Solution")
try:
    result = 10 / 0
    print(result)
except ZeroDivisionError:
    print("Cannot divide by zero")
finally:
    print("Operation finished")


print("\nRank 3 — Solution")

def calculate():
    try:
        return 100
    finally:
        print("Cleanup before return")


print("Returned value:", calculate())


print("\nRank 4 — Solution")
for i in range(5):
    try:
        print("Loop value:", i)
        if i == 2:
            break
    finally:
        print("Loop cleanup")


print("\nRank 5 — Solution")
file = None
try:
    file = open("task_file.txt", "w", encoding="utf-8")
    file.write("This file is safely handled using finally.\n")
    print("File written successfully")
    _ = 10 / 0
except ZeroDivisionError:
    print("Intentional error occurred")
finally:
    if file is not None:
        file.close()
        print("File closed safely (finally executed)")
