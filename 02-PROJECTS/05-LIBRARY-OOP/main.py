from models.libro import Libro
from services.biblioteca import Biblioteca


# Crear libros
libro1 = Libro("Cien años de soledad", "Gabriel García Márquez", 1967)
libro2 = Libro("Don Quijote", "Miguel de Cervantes", 1605)
libro3 = Libro("El Principito", "Antoine de Saint-Exupéry", 1943)

# Crear biblioteca
bib = Biblioteca("Biblioteca Central")

# Agregar libros
bib.agregar_libro(libro1)
bib.agregar_libro(libro2)
bib.agregar_libro(libro3)


print("\n📚 Sistema de préstamo de biblioteca\n")

while True:

    print("----- NUEVO PRÉSTAMO -----")

    nombre = input("Ingrese nombre: ")
    apellido = input("Ingrese apellido: ")

    titulo = input("Ingrese título del libro: ")
    autor = input("Ingrese autor del libro: ")
    año = int(input("Ingrese año de publicación: "))

    libro = bib.buscar_por_titulo(titulo)

    if libro:

        if libro.autor.lower() == autor.lower() and libro.año_publicacion == año:

            if libro.disponible:
                print(f"\n📖 Libro encontrado para {nombre} {apellido}")
                libro.prestar()
            else:
                print("\n❌ El libro ya está prestado.")

        else:
            print("\n❌ Los datos del libro no coinciden.")

    else:
        print("\n❌ Libro no encontrado en la biblioteca.")

    repetir = input("\n¿Desea hacer otro préstamo? (s/n): ")

    if repetir.lower() != "s":
        print("\n👋 Fin del sistema de préstamos.")
        break