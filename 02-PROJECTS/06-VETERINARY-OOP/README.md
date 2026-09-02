# Project 06 — Veterinary OOP

A Python object-oriented veterinary-system demonstration using a shared animal model and specialized animal types.

## Included animal types

- `Perro`
- `Gato`
- `Ave`

## Concepts demonstrated

- inheritance;
- encapsulation;
- polymorphism;
- method specialization;
- shared behavior through a base class;
- collections of heterogeneous objects;
- automated behavior tests.

## Structure

```text
06-VETERINARY-OOP/
├── animal.py
├── perro.py
├── gato.py
├── ave.py
├── main.py
├── tests/
│   └── test_veterinary.py
└── README.md
```

## Run

```bash
python main.py
```

## Test

```bash
python -m unittest discover -s tests -v
```

The demonstration creates sample animals, prints their information, performs vaccination/consultation actions, calls type-specific services, and generates a final summary.

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026
