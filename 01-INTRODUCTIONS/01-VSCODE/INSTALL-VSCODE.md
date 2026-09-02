# Install Visual Studio Code

## 1. Download VS Code

Use the official Visual Studio Code website and download the installer for your operating system.

## 2. Install VS Code

During installation:

- keep the default options unless you have a specific reason to change them;
- enable the option to add VS Code to your PATH when available;
- optionally enable context-menu entries such as **Open with Code**.

## 3. Install Python support

Open VS Code and install the official **Python** extension published by Microsoft.

The extension provides:

- Python interpreter selection;
- code execution;
- debugging;
- syntax highlighting;
- IntelliSense integration;
- test discovery.

For stronger type analysis and completions, also install **Pylance**.

## 4. Select the Python interpreter

1. Open the Command Palette with `Ctrl + Shift + P`.
2. Search for **Python: Select Interpreter**.
3. Select the Python installation or virtual environment for your project.

## 5. Create a first Python file

Create a file named `main.py`:

```python
print("Hello from Visual Studio Code!")
```

Run it from the VS Code terminal:

```bash
python main.py
```

## Verification checklist

- [ ] VS Code opens correctly.
- [ ] The Microsoft Python extension is installed.
- [ ] A Python interpreter is selected.
- [ ] `python --version` works in the terminal.
- [ ] `main.py` runs successfully.

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026
