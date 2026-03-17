🧵 Module —  Custom Exceptions — (Class-Based)
---------------------------------------------------------------

## 📌 What Are Custom Exceptions?

In Python, **custom exceptions** are user-defined error types created by **extending the built-in `Exception` class**.

They allow you to:

* Represent **specific error situations** clearly
* Make your code **more readable and professional**
* Handle errors in a **controlled and meaningful way**

Instead of using generic errors like `ValueError`, you can create errors that explain *exactly what went wrong*.

---

## 🧠 Why Use Custom Exceptions?

Imagine this error:

```text
ValueError: invalid input
```

Now compare it with:

```text
AgeTooLowError: User must be at least 18 years old
```

✅ The second one is:

* Easier to understand
* Easier to debug
* Easier to maintain in large projects

---

## 🧩 Basic Syntax

```python
class MyCustomError(Exception):
    pass
```

📌 Rules:

* Custom exceptions **must inherit from `Exception`** (directly or indirectly)
* Class names usually end with `Error`

---------------------------------------------------------------------

## 🧪 Simple Example

```python
class AgeTooLowError(Exception):
    pass

age = 15

if age < 18:
    raise AgeTooLowError("User must be at least 18")
```

------------------------------------------------------------------

## 🔗 Using Custom Exceptions with try / except

```python
class NegativeNumberError(Exception):
    pass

try:
    number = int(input("Enter a number: "))
    if number < 0:
        raise NegativeNumberError("Negative numbers are not allowed")
except NegativeNumberError as e:
    print("Custom error:", e)
```

-------------------------------------------------------------
## 🏗️ Adding Custom Messages
You can pass messages to your exception:
```python
class LoginError(Exception):
    def __init__(self, message):
        super().__init__(message)
---
----------------------------------------------------------------
## 🧠 Best Practices

✅ Use custom exceptions for **business logic errors**
✅ Keep exception names descriptive
✅ Catch custom exceptions separately when needed

❌ Do not overuse custom exceptions for simple scripts
❌ Do not hide real system errors unnecessarily
---
## 🆚 Built-in vs Custom Exceptions

| Built-in         | Custom           |
| ---------------- | ---------------- |
| General purpose  | Specific meaning |
| Less descriptive | Very descriptive |
| Faster to write  | Cleaner design   |

------------------------------------------------------------------------

## 🏁 Summary

* Custom exceptions are **class-based errors**
* They improve clarity and structure
* Used together with `raise`, `try`, and `except`
* Essential for **professional and large-scale Python projects**
-----------------------------------------------------------------------
👤 Author
Peyman Miyandashti
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
-----------------------------------------------------------------------
