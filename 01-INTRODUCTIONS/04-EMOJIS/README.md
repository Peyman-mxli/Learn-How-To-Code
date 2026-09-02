# Unicode, Symbols, ALT Codes, and Emojis

This module explains special characters, Windows ALT input, Unicode, and emojis in console programs.

## Learning objectives

By the end of this module, I can:

- explain the difference between ALT input and Unicode;
- print Unicode characters and emojis in Python;
- build readable console separators, menus, and tables;
- recognize terminal/font limitations;
- design console output without sacrificing accessibility.

## Important distinction

**ALT codes** are a Windows input method. **Unicode** is the character standard used by Python strings.

Python can store the character directly:

```python
print("Status: ✅ Complete")
print("Arrow: →")
print("Box: ╔══╗")
```

The exact ALT-number sequence used to type a symbol can vary by Windows code page and application, so application code should not depend on ALT numbers.

## Module files

- `ALT-CODES-NOTES.py` — concise notes plus small demonstrations
- `ALT-CODES-EXAMPLES.py` — runnable Unicode console examples
- `TASKS.py` — exercises
- `TASK-SOLUTION.py` — reference solutions

Run an example:

```bash
python ALT-CODES-EXAMPLES.py
```

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026
