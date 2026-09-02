🧵 Module —  Exception Chaining — (raise ... from ...)
---------------------------------------------------------------------
## 📌 What Is Exception Chaining?

**Exception chaining** allows you to raise a new exception **while preserving the original one** that caused it.

In Python, this is done using:

```python
raise NewException() from OriginalException
```

This creates a **clear cause → effect relationship** between errors.

---

## 🧠 Why Exception Chaining Matters

Without chaining, important debugging information can be lost.

### ❌ Without chaining

```python
except ValueError:
    raise RuntimeError("Something failed")
```

* Original error is hidden
* Debugging becomes harder

### ✅ With chaining

```python
except ValueError as e:
    raise RuntimeError("Something failed") from e
```

* Original cause is preserved
* Stack trace clearly shows **what failed first**

---

## 🧩 Basic Syntax

```python
try:
    risky_code()
except OriginalError as e:
    raise NewError("New context message") from e
```

📌 The `from` keyword explicitly links exceptions.

---

## 🔍 How Python Displays Chained Exceptions

Python shows:

* The **original exception** (cause)
* Followed by:

  ```text
  The above exception was the direct cause of the following exception:
  ```
* Then the **new exception**

This is extremely useful for debugging.

---

## 🧪 Example — ValueError → Custom Exception

```python
class DataFormatError(Exception):
    pass

try:
    value = int("abc")
except ValueError as e:
    raise DataFormatError("Invalid data format") from e
```

---

## 🚫 Suppressing Context (Advanced)

You can suppress the original exception context using:

```python
raise NewError() from None
```

📌 This hides the original exception completely.

Use this **carefully**.

---

## 🆚 `raise ... from ...` vs Normal `raise`

| Feature              | Normal raise | raise ... from ... |
| -------------------- | ------------ | ------------------ |
| Keeps original error | ❌           | ✅                |
| Clear cause tracking | ❌           | ✅                |
| Debugging friendly   | ⚠️           | ✅                |

---

## 🧠 Best Practices

✅ Use chaining when converting low-level errors into high-level ones
✅ Chain built-in exceptions into custom exceptions
❌ Do not chain if it adds no clarity
❌ Do not suppress context unless absolutely necessary

----------------------------------------------------------------------
## 🏁 Summary
* Exception chaining preserves error causes
* Uses `raise NewError from old_error`
* Improves debugging and error transparency
* Essential for **professional Python applications**

-----------------------------------------------------------------------
👤 Author
Peyman Miyandashti
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
-----------------------------------------------------------------------

