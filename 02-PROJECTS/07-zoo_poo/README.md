🦁 ZooPOO — Sistema de Gestión de Zoológico (POO)
📚 Descripción del Proyecto

Este proyecto implementa un Sistema de Gestión de Zoológico utilizando los cuatro pilares fundamentales de la Programación Orientada a Objetos (POO) en Python:

Abstracción
Encapsulamiento
Herencia
Polimorfismo

El sistema permite registrar animales, gestionar cuidadores, realizar revisiones médicas, ejecutar un tour virtual y generar reportes generales.

🎯 Objetivo

Desarrollar una aplicación orientada a objetos que modele el funcionamiento básico de un zoológico municipal, demostrando buenas prácticas de diseño y programación.

🧠 Conceptos de POO Aplicados
🔷 Abstracción

La clase Animal es abstracta, por lo tanto no puede ser instanciada directamente.

🔒 Encapsulamiento

El atributo _estado_salud es privado y solo puede modificarse mediante el método:

actualizar_salud()

o a través de un Cuidador.

🧬 Herencia

Las clases:

Mamifero
Ave
Reptil

heredan de la clase base Animal.

🎭 Polimorfismo

Los métodos:

hacer_sonido()
tipo_alimentacion()

se implementan de forma diferente en cada tipo de animal.

📁 Estructura del Proyecto
zoo_poo/
│
├── animal.py
├── mamifero.py
├── ave.py
├── reptil.py
├── cuidador.py
├── zoologico.py
├── main.py
│
└── diagram/
    ├── classes.drawio
    ├── objects.drawio
    ├── combined.drawio
    └── use_case.drawio
▶️ Cómo Ejecutar el Proyecto

Abrir terminal (PowerShell) dentro de la carpeta zoo_poo y ejecutar:

py main.py

El sistema mostrará:

Registro de animales
Actualización de estado de salud
Demostración de polimorfismo
Tour virtual del zoológico
Reporte general
🧪 Casos de Prueba
Intentar crear un Animal() directamente → debe generar error (clase abstracta)
Intentar actualizar salud con estado inválido → debe mostrar mensaje
El tour virtual debe funcionar con cualquier combinación de animales

=============================================================================
Author
👤 Peyman Miyandashti 
🎓 Polytechnic University of Baja California 
💻 Information Technology Engineering & Digital Innovation 
📍 Mexico 
📅 2026 
🆔 250161.
