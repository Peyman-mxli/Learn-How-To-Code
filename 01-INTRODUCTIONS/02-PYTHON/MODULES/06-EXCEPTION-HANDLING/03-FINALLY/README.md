Module — Exception Handling — (finally)

## 📌 What is `finally` in Python?

The `finally` block is part of **exception handling control flow** in Python.
It defines a section of code that **always executes**, no matter what happens:

* ✅ If no error occurs
* ❌ If an exception occurs
* 🔁 Even if there is a `return`, `break`, or `continue`

This makes `finally` **critical for cleanup operations**.

---

## 🧠 Why `finally` Exists

In real programs, some actions **must always happen**, such as:

* Closing files
* Releasing resources
* Closing database connections
* Freeing memory or locks
* Logging execution completion

The `finally` block guarantees that these actions run **100% of the time**.

---

## 🧩 Basic Syntax

```python
try:
    # Code that may raise an exception
except SomeError:
    # Runs only if that exception occurs
finally:
    # Always runs
```

You can also use `finally` **without** `except`:

```python
try:
    print("Running")
finally:
    print("This always runs")
```

---

## 🔄 Execution Flow Explained

| Situation             | Does `finally` run? |
| --------------------- | ------------------- |
| No error              | ✅ Yes               |
| Exception handled     | ✅ Yes               |
| Exception not handled | ✅ Yes               |
| `return` inside try   | ✅ Yes               |
| `break` / `continue`  | ✅ Yes               |

📌 **Nothing skips `finally`.**

---

## 🧪 Example 1 — No Error

```python
try:
    x = 10 / 2
    print(x)
finally:
    print("Cleanup complete")
```

### Output:

```
5.0
Cleanup complete
```

---

## 🧪 Example 2 — With Error

```python
try:
    x = 10 / 0
except ZeroDivisionError:
    print("Division error")
finally:
    print("Cleanup complete")
```

### Output:

```
Division error
Cleanup complete
```

---

## 🧪 Example 3 — `finally` with `return`

```python
def test():
    try:
        return "Returned from try"
    finally:
        print("Finally executed")

print(test())
```

### Output:

```
Finally executed
Returned from try
```

📌 Even `return` **does not stop** `finally`.

---------------------------------------------------------------------------

## ⚠️ Important Rule

> The `finally` block **cannot prevent execution flow** — it only guarantees execution.

If an exception is not handled, Python will:

1. Run `finally`
2. Then crash the program

-------------------------------------------------------------------------------------

## 🆚 `finally` vs `else`

| Feature                    | `else`   | `finally`  |
| -------------------------- | ------   | ---------  |
| Runs when no exception     | ✅      | ✅         |
| Runs when exception occurs | ❌      | ✅         |
| Used for cleanup           | ❌      | ✅         |

-----------------------------------------------------------------------

## 🧠 Best Practices

✅ Use `finally` for cleanup only

❌ Do NOT use `finally` for normal logic

✅ Keep `finally` short and safe

❌ Avoid raising new exceptions inside `finally`
---
## 🔗 Relationship to `with`

The `with` statement internally uses `try/finally`.

```python
with open("file.txt") as f:
    data = f.read()
```

Equivalent to:

```python
f = open("file.txt")
try:
    data = f.read()
finally:
    f.close()
----------------------------------------------------------------------
## 🏁 Summary
* `finally` is a **guaranteed execution block**
* It always runs, no matter what
* Essential for resource management
* Commonly used with files, databases, and system resources

-----------------------------------------------------------------------
👤 Author
Peyman Miyandashti
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
-----------------------------------------------------------------------
