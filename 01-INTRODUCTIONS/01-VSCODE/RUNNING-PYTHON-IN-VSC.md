# Run Python in Visual Studio Code

## Option 1 — Run button

Open a Python file and use **Run Python File** from the editor.

## Option 2 — Integrated terminal

Open the terminal and run:

```bash
python main.py
```

On some systems the command may be:

```bash
python3 main.py
```

## VS Code interface

| Area | Purpose |
|---|---|
| Explorer | Browse project files |
| Editor | Write and edit code |
| Terminal | Run commands and programs |
| Extensions | Install language/tool support |
| Source Control | Work with Git |
| Status Bar | See interpreter and project status |

## Useful beginner settings

Consider enabling:

- Auto Save;
- line numbers;
- word wrap;
- format on save.

## Common problems

### Python is not found

Verify Python is installed and available on PATH:

```bash
python --version
```

### Wrong interpreter

Use **Python: Select Interpreter** from the Command Palette.

### Virtual environment is not active

Activate the environment before installing or running project dependencies.

### Program runs from the wrong directory

Use the terminal to confirm your current location:

```bash
pwd
```

On Windows PowerShell:

```powershell
Get-Location
```

## Ready-to-continue checklist

- [ ] Python is installed.
- [ ] The VS Code Python extension is installed.
- [ ] The correct interpreter is selected.
- [ ] A `.py` file runs successfully.

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026
