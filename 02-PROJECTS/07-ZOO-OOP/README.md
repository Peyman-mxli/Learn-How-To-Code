# Project 07 — Zoo OOP

A Python zoo-management exercise demonstrating abstraction, encapsulation, inheritance, and polymorphism.

## Model

- `Animal` — abstract base class
- `Mamifero`
- `Ave`
- `Reptil`
- `Cuidador`
- `Zoologico`

## Demonstrated behavior

- register animals and caregivers;
- update animal health through controlled methods;
- execute polymorphic sound/feeding behavior;
- run a virtual tour;
- generate a general zoo report;
- validate expected behavior with automated tests.

## Run

```bash
python main.py
```

## Test

```bash
python -m unittest discover -s tests -v
```

## UML diagram

The editable diagrams.net source is available at:

`diagram/classes.drawio`

Open it with diagrams.net / draw.io to inspect or modify the class diagram.

## Automated test coverage

The tests verify that:

- the abstract `Animal` class cannot be instantiated;
- invalid health states are rejected;
- valid health states are stored;
- mixed animal collections support polymorphic behavior;
- caregiver and animal registration work.

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026
