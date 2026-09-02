from models.libro import Libro


class Biblioteca:
    """Gestiona una colección de objetos Libro."""

    def __init__(self, nombre: str):
        nombre = nombre.strip()
        if not nombre:
            raise ValueError("El nombre de la biblioteca no puede estar vacío.")
        self.nombre = nombre
        self.libros: list[Libro] = []

    def agregar_libro(self, libro: Libro) -> None:
        if not isinstance(libro, Libro):
            raise TypeError("Solo se pueden agregar objetos Libro.")
        self.libros.append(libro)

    def buscar_por_titulo(self, titulo: str) -> Libro | None:
        query = titulo.strip().casefold()
        if not query:
            return None
        for libro in self.libros:
            if libro.titulo.casefold() == query:
                return libro
        return None

    def libros_disponibles(self) -> list[Libro]:
        return [libro for libro in self.libros if libro.disponible]

    def listar_disponibles(self) -> None:
        print(f"\n📖 Libros disponibles en {self.nombre}:")
        disponibles = self.libros_disponibles()
        if not disponibles:
            print("   (No hay libros disponibles)")
            return
        for index, libro in enumerate(disponibles, 1):
            print(f"   {index}. {libro.titulo} — {libro.autor} ({libro.año_publicacion})")

    def contar_libros(self) -> int:
        return len(self.libros)
