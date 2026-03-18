from perro import Perro
from gato import Gato
from ave import Ave


print("===== SISTEMA VETERINARIA PATITAS FELICES =====")


# CREAR ANIMALES
perro1 = Perro("Max", 3, 20, "Carlos", "P001", "Labrador")
perro2 = Perro("Rocky", 1, 15, "Ana", "P002", "Bulldog")

gato1 = Gato("Michi", 2, 5, "Laura", "G001", "Negro", True)
gato2 = Gato("Luna", 1.5, 4, "Pedro", "G002", "Blanco", False)

ave1 = Ave("Piolin", 1, 0.5, "Maria", "A001", "Canario", True, "Mediana")
ave2 = Ave("Pepe", 4, 1.2, "Luis", "A002", "Loro", True, "Grande")


# LISTA GLOBAL DE ANIMALES
animales = [perro1, perro2, gato1, gato2, ave1, ave2]


print("\n===== INFORMACIÓN DE LOS ANIMALES =====")

for animal in animales:
    print(animal.mostrar_info())


print("\n===== SONIDOS =====")

for animal in animales:
    print(animal.hacer_sonido())


print("\n===== VACUNACIÓN =====")

for animal in animales:
    animal.vacunar()


print("\n===== CONSULTAS =====")

perro1.agregar_consulta("Chequeo general")
gato1.agregar_consulta("Dolor estomacal")
ave2.agregar_consulta("Revisión de alas")


print("\n===== SERVICIOS ESPECIALES =====")

perro1.adiestrar()
perro1.pasear()

gato1.cortar_unas()
gato2.cambiar_ambiente()

ave2.entrenar_habla()
ave1.cortar_plumas()


print("\n===== REPORTE FINAL =====")

for animal in animales:
    print(f"{animal.get_nombre()} tiene {animal.contar_consultas()} consultas registradas.")