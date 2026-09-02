🧵 Module — Exception Handling — (raise)
----------------------------------------------------------------------------
## 📌 What is `raise` in Python?

The `raise` keyword is used to **manually trigger (throw) an exception**.

While many exceptions happen automatically (like division by zero), `raise` gives you **full control** to:

* Stop program execution intentionally
* Signal that something went wrong
* Enforce rules and validations
* Create clean, predictable error handling

`raise` is a **control-flow tool**, because it immediately changes the execution path of a program.

---

## 🧠 Why `raise` Exists

In real-world programs, not all errors come from Python itself.
Sometimes **your logic detects a problem** before Python does.

Examples:

* Invalid user input
* Negative values where only positives are allowed
* Unauthorized access
* Business-rule violations

In these cases, `raise` lets **you define what is considered an error**.

---

## 🧩 Basic Syntax

```python
raise ExceptionType("Optional error message")
```

Example:

```python
raise ValueError("Age cannot be negative")
```

📌 When `raise` is executed, Python immediately stops normal execution and looks for a matching `except` block.

---

## 🔄 Execution Flow

1. Python encounters `raise`
2. Normal execution stops
3. Python searches for a matching `except`
4. If found → exception is handled
5. If not found → program crashes
6. `finally` (if present) ALWAYS runs before exit

---

## 🧪 Example 1 — Raising a Built-in Exception

```python
age = -5

if age < 0:
    raise ValueError("Age must be positive")

print("This line will never run")
```

---

## 🧪 Example 2 — `raise` Inside `try / except`

```python
try:
    number = int(input("Enter a positive number: "))
    if number <= 0:
        raise ValueError("Number must be greater than zero")
except ValueError as e:
    print("Error:", e)
```
-----------------------------------------------------------------------------

## 🔁 Re-raising Exceptions
You can re-raise an exception after catching it:
```python
try:
    x = int("abc")
except ValueError:
    print("Logging the error")
    raise
```
📌 This keeps the original error and traceback.
-----------------------------------------------------------------------------
## 🧱 Creating Custom Exceptions (Intro)

You can define your own exception types:

```python
class InvalidAgeError(Exception):
    pass
raise InvalidAgeError("Custom age error")
```
Custom exceptions improve **code clarity and debugging**.
---
## 🆚 `raise` vs `return`
| Feature                  | `return`   |  `raise` |
| ------------------------ | --------   |  ------- |
| Stops function execution | ✅        | ✅       |
| Indicates success        | ✅        | ❌       |
| Indicates error          | ❌        | ✅       |
| Can be caught            | ❌        | ✅       |

-------------------------------------------------------------------------
## ⚠️ Important Rules
* `raise` immediately stops normal execution
* Code after `raise` does NOT run
* `finally` still executes
* Avoid raising generic `Exception`
* Prefer specific exception types
-------------------------------------------------------------------------
## 🧠 Best Practices
✅ Use `raise` to enforce rules
✅ Raise meaningful exceptions
✅ Use clear error messages
❌ Do not use `raise` for normal logic
❌ Do not silence exceptions without reason
------------------------------------------------------------------------
## 🏁 Summary

* `raise` gives you manual control over errors
* It is essential for robust and professional code
* Often used with validation, APIs, and libraries
* Works hand-in-hand with `try / except / finally`

-----------------------------------------------------------------------
👤 Author
Peyman Miyandashti
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
-----------------------------------------------------------------------
