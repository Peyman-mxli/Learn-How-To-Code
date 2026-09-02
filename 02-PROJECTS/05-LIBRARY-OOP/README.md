# Project 05 — Library OOP

A Python object-oriented library-management exercise.

## Concepts

- classes and objects;
- composition;
- separation of concerns;
- package/module organization;
- searching collections;
- lending and returning state;
- input validation and exception handling;
- automated tests.

## Current structure

```text
05-LIBRARY-OOP/
├── main.py
├── models/
│   ├── __init__.py
│   └── libro.py
├── services/
│   ├── __init__.py
│   └── biblioteca.py
├── tests/
│   └── test_library.py
├── info/
│   └── poo.html
└── README.md
```

`info/poo.html` is supplementary OOP reference material. The executable application uses the modules under `models/` and `services/`.

## Validation

The current year is calculated dynamically with Python's `datetime` module, so year validation does not become outdated every January.

Invalid titles, authors, publication years, and non-numeric console input are handled explicitly.

## Run

```bash
python main.py
```

## Test

```bash
python -m unittest discover -s tests -v
```

The project uses the Python standard library only.

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026
