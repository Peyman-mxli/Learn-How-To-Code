# Projects

This section applies the concepts from `01-INTRODUCTIONS` in complete applications. The projects progress from small command-line programs to object-oriented systems and a Flask web application.

## Project index

| # | Project | Main focus |
|---:|---|---|
| 01 | [CLI Calculator](./01-CLI-CALCULATOR/) | Functions, input validation, control flow |
| 02 | [Todo App](./02-TODO-APP/) | CRUD-style operations and state management |
| 03 | [Vehicle Management System](./03-VEHICLE-MANAGEMENT-SYSTEM/) | OOP, inheritance, abstraction, polymorphism |
| 04 | [UniTrack](./04-UNITRACK/) | Flask, authentication, SQLite, attendance workflow |
| 05 | [Library OOP](./05-LIBRARY-OOP/) | Multi-module OOP library system |
| 06 | [Veterinary OOP](./06-VETERINARY-OOP/) | Inheritance and polymorphism with animal models |
| 07 | [Zoo OOP](./07-ZOO-OOP/) | Abstract classes, caregivers, zoo management |

## Project standards

Projects should include, when applicable:

- a clear `README.md`;
- a conventional entry point such as `main.py` or `app.py`;
- `requirements.txt` for external Python dependencies;
- `.gitignore` rules for virtual environments, caches, databases, and secrets;
- input validation and explicit error handling;
- no hard-coded production secrets or passwords;
- no committed `__pycache__` or `.pyc` files; and
- reproducible run instructions.

## Recommended workflow

1. Create a virtual environment.
2. Install dependencies.
3. Run the project.
4. Test normal and invalid input.
5. Read and refactor the code.
6. Add tests for reusable functions.
7. Commit changes with a descriptive message.

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026


## Automated validation

Automated tests are included for the CLI Calculator, Todo App, UniTrack, and the C# Student Management System. GitHub Actions runs these checks on pushes and pull requests.
