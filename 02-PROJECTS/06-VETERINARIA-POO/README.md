# 🧵 Project — Sistema de Veterinaria "Patitas Felices"
=======================================
# ✨ Overview
=============================================================================
El sistema **"Patitas Felices"** es una aplicación desarrollada en Python
utilizando Programación Orientada a Objetos (POO).
Este proyecto simula la gestión básica de una veterinaria,
permitiendo registrar animales, administrar consultas médicas
y aplicar servicios específicos según el tipo de animal.
El sistema representa un modelo real de cómo se estructuran
aplicaciones orientadas a objetos en escenarios del mundo real.
=============================================================================
🎯 Objetivo
El objetivo principal es aplicar los principios fundamentales
de la Programación Orientada a Objetos:
Encapsulamiento  
Herencia  
Polimorfismo  
Uso de getters y métodos de clase  
=============================================================================
📦 Conceptos Aplicados
Este proyecto demuestra:
Clases y Objetos  
Encapsulación de datos  
Herencia (clase base → clases derivadas)  
Polimorfismo (comportamientos diferentes)  
Diseño modular y organizado  
=============================================================================
📂 Estructura del Proyecto
plaintext
veterinaria_poo/
│
├── animal.py
├── perro.py
├── gato.py
├── ave.py
├── main.py
└── README.md
=============================================================================
🐾 Clases del Sistema
🔹 Animal (Clase Base)
Contiene atributos y comportamientos comunes:
Atributos:
nombre
edad
peso
dueño
código
vacunado
historial de consultas
Métodos:
vacunar()
agregar_consulta()
cambiar_peso()
contar_consultas()
hacer_sonido()
mostrar_info()
🐶 Perro
Hereda de Animal y añade:
Atributos:
raza
adiestrado
Métodos:
adiestrar()
pasear()
🐱 Gato
Hereda de Animal y añade:
Atributos:
color
vive en interior
Métodos:
cambiar_ambiente()
cortar_uñas()
🐦 Ave
Hereda de Animal y añade:
Atributos:
especie
puede volar
tamaño de jaula
Métodos:
cortar_plumas()
entrenar_habla()
=============================================================================
⚙️ Funcionalidades del Sistema
El sistema permite:
Registrar animales
Mostrar información de pacientes
Ejecutar sonidos (polimorfismo)
Vacunar animales
Registrar consultas médicas
Aplicar servicios específicos
Generar reportes
=============================================================================
⚙️ Cómo Funciona
El sistema sigue esta lógica:
Se crean objetos de diferentes animales
Cada clase extiende la clase base Animal
Se ejecutan métodos según el tipo de objeto
El sistema gestiona información y acciones dinámicamente
Esto demuestra el uso real de herencia y polimorfismo.
=============================================================================
▶️ Cómo Ejecutar el Programa
Abrir la terminal en la carpeta del proyecto
Ejecutar:
python main.py
o
py main.py
=============================================================================
🧠 What You Will Learn
Cómo aplicar POO en proyectos reales
Cómo diseñar jerarquías de clases
Cómo usar herencia correctamente
Cómo implementar polimorfismo
Cómo estructurar código limpio y mantenible
=============================================================================
⚠️ Professional Impact
Este proyecto representa un paso importante hacia:
Diseño de sistemas reales
Arquitectura basada en objetos
Desarrollo de aplicaciones escalables
Demuestra tu capacidad para modelar sistemas del mundo real
utilizando principios profesionales de programación.
=============================================================================
💻 Tecnologías Utilizadas
Python 3
Programación Orientada a Objetos (POO)
=============================================================================
📜 Licencia
Proyecto desarrollado con fines académicos y educativos.
===========================================================================
👤 Author
===========================================================================
Peyman Miyandashti
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
===========================================================================
