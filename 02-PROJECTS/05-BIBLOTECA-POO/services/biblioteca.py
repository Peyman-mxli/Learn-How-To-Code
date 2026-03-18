class Biblioteca:
    """Gestiona una colección de objetos Libro."""

    def __init__(self, nombre: str):
        self.nombre = nombre
        self.libros = []

    def agregar_libro(self, libro):
        self.libros.append(libro)
        print(f'📚 "{libro.titulo}" agregado a {self.nombre}.')

    def buscar_por_titulo(self, titulo: str):
        for libro in self.libros:
            if libro.titulo.lower() == titulo.lower():
                return libro
        return None

    def listar_disponibles(self):
        print(f"\n📖 Libros disponibles en {self.nombre}:")

        disponibles = [l for l in self.libros if l.disponible]

        if not disponibles:
            print("   (No hay libros disponibles)")
        else:
            for i, libro in enumerate(disponibles, 1):
                print(f"   {i}. {libro.titulo} — {libro.autor} ({libro.año_publicacion})")

    def contar_libros(self):
        return len(self.libros)