# Project 03 — Vehicle Management System

A Python object-oriented programming project that models several vehicle types through a shared abstract base class.

## Concepts demonstrated

- abstract base classes;
- inheritance;
- encapsulation;
- polymorphism;
- package organization;
- type-specific behavior.

## Vehicle types

- `Automovil`
- `Motocicleta`
- `Camion`
- `Bicicleta`

## Current structure

```text
03-VEHICLE-MANAGEMENT-SYSTEM/
├── app/
│   ├── __init__.py
│   └── modelos/
│       ├── __init__.py
│       ├── vehiculo.py
│       ├── automovil.py
│       ├── motocicleta.py
│       ├── camion.py
│       └── bicicleta.py
├── main.py
├── STRUCTURE.md
└── README.md
```

The current version is intentionally a **console application**. Old unused dashboard template/static files were removed so the repository matches the executable implementation.

## Run

From this project directory:

```bash
python main.py
```

## Encapsulation

The base class exposes `velocidad_actual` as a read-only property. Code outside the class no longer reads the protected `_velocidad_actual` attribute directly.

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026
