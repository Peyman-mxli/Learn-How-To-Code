from models.libro import Libro
from services.biblioteca import Biblioteca


def pedir_texto(prompt: str) -> str:
    """Solicita texto no vacío."""
    while True:
        value = input(prompt).strip()
        if value:
            return value
        print("❌ Este campo no puede estar vacío.")


def pedir_año(prompt: str) -> int:
    """Solicita un año entero válido."""
    while True:
        raw = input(prompt).strip()
        try:
            return int(raw)
        except ValueError:
            print("❌ Ingrese un año válido usando solo números.")


def crear_biblioteca_demo() -> Biblioteca:
    biblioteca = Biblioteca("Biblioteca Central")

    for libro in (
        Libro("Cien años de soledad", "Gabriel García Márquez", 1967),
        Libro("Don Quijote", "Miguel de Cervantes", 1605),
        Libro("El Principito", "Antoine de Saint-Exupéry", 1943),
    ):
        biblioteca.agregar_libro(libro)

    return biblioteca


def procesar_prestamo(biblioteca: Biblioteca) -> None:
    nombre = pedir_texto("Ingrese nombre: ")
    apellido = pedir_texto("Ingrese apellido: ")
    titulo = pedir_texto("Ingrese título del libro: ")
    autor = pedir_texto("Ingrese autor del libro: ")
    año = pedir_año("Ingrese año de publicación: ")

    libro = biblioteca.buscar_por_titulo(titulo)

    if libro is None:
        print("\n❌ Libro no encontrado en la biblioteca.")
        return

    if libro.autor.casefold() != autor.casefold() or libro.año_publicacion != año:
        print("\n❌ Los datos del libro no coinciden.")
        return

    if libro.prestar():
        print(f"\n📖 Libro prestado correctamente a {nombre} {apellido}.")
    else:
        print("\n❌ El libro ya está prestado.")


def main() -> None:
    biblioteca = crear_biblioteca_demo()
    print("\n📚 Sistema de préstamo de biblioteca\n")

    while True:
        print("----- NUEVO PRÉSTAMO -----")
        procesar_prestamo(biblioteca)

        repetir = input("\n¿Desea hacer otro préstamo? (s/n): ").strip().lower()
        if repetir != "s":
            print("\n👋 Fin del sistema de préstamos.")
            break


if __name__ == "__main__":
    main()
