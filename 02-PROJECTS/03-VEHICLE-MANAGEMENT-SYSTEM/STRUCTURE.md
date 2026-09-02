# Vehicle Management System Structure

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
├── README.md
└── STRUCTURE.md
```

## Responsibilities

- `main.py` — demonstration entry point and fleet report.
- `vehiculo.py` — abstract base class and shared vehicle behavior.
- `automovil.py` — automobile specialization.
- `motocicleta.py` — motorcycle specialization.
- `camion.py` — truck specialization.
- `bicicleta.py` — bicycle specialization.

The project currently has no web framework dependency. Its earlier unused HTML/CSS/JavaScript dashboard assets were removed to avoid implying a web application that is not actually executed.
