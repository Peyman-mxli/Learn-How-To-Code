🧵 Module — Exception Handling — (try / else)
-----------------------------------------------------------------------

## 📌 What is `else` in `try`?

In Python exception handling, the `else` block is used **after `try` and `except`**.

The `else` block runs **only if the `try` block finishes successfully** — meaning:

* ✅ No exception occurred in `try`
* ❌ If an exception occurs, `else` is skipped

This makes `else` perfect for **code that should run only when everything went right**.

---

## 🧠 Why `else` Exists

Without `else`, many beginners put **too much code inside `try`**, which is bad practice.

`else` helps you:

* Keep `try` blocks small and clean
* Separate risky code from safe code
* Improve readability and debugging

👉 Rule of thumb:

> **Only put code that may fail inside `try`.**

---

## 🧩 Basic Syntax

```python
try:
    # Code that may raise an exception
except SomeError:
    # Runs if exception occurs
else:
    # Runs ONLY if no exception occurred
```

📌 `else` must come **after all except blocks** and **before finally** (if used).

---

## 🔄 Execution Flow

| Situation    | try | except | else | finally |
| ------------ | --- | ------ | ---- | ------- |
| No error     | ✅   | ❌      | ✅    | ✅       |
| Error occurs | ❌   | ✅      | ❌    | ✅       |

---

## 🧪 Example 1 — Simple try / else

```python
try:
    x = int("10")
except ValueError:
    print("Conversion failed")
else:
    print("Conversion successful:", x)
```

---

## 🧪 Example 2 — Using else correctly

```python
try:
    number = int(input("Enter a number: "))
except ValueError:
    print("Invalid input")
else:
    print("You entered:", number)
```

📌 Input validation belongs in `try`, logic belongs in `else`.

---

## ❌ Common Mistake (Bad Practice)

```python
try:
    x = int(input())
    print(x * 2)  # ❌ Should NOT be here
except ValueError:
    print("Error")
```

✅ Better version:

```python
try:
    x = int(input())
except ValueError:
    print("Error")
else:
    print(x * 2)
```

---

## 🔗 Relationship with `finally`

You can use `else` together with `finally`:

```python
try:
    file = open("data.txt")
except FileNotFoundError:
    print("File not found")
else:
    print("File opened successfully")
finally:
    file.close()
```

📌 Order is always:

```text
try → except → else → finally
```

---

## 🆚 `else` vs `finally`

| Feature               | `else`   | `finally`  |
| --------------------- | ------   | ---------  |
| Runs only if no error | ✅      | ❌         |
| Runs if error occurs  | ❌      | ✅         |
| Used for logic        | ✅      | ❌         |
| Used for cleanup      | ❌      | ✅         |

---------------------------------------------------------------------

## 🧠 Best Practices

✅ Keep `try` blocks minimal
✅ Use `else` for post-success logic
❌ Do not put cleanup code in `else`
❌ Do not use `else` without `except`
---------------------------------------------------------------------

## 🏁 Summary

* `else` runs only when `try` succeeds
* It improves readability and structure
* Separates risky code from safe logic
* Commonly used with input validation and file handling
-----------------------------------------------------------------------
👤 Author
Peyman Miyandashti
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
-----------------------------------------------------------------------
