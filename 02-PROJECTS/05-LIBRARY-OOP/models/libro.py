from datetime import date


class Libro:
    """Representa un libro en la biblioteca."""

    def __init__(self, titulo: str, autor: str, año_publicacion: int):
        titulo = titulo.strip()
        autor = autor.strip()
        current_year = date.today().year

        if not titulo:
            raise ValueError("El título no puede estar vacío.")
        if not autor:
            raise ValueError("El autor no puede estar vacío.")
        if not isinstance(año_publicacion, int):
            raise TypeError("El año de publicación debe ser un número entero.")
        if año_publicacion < 1000 or año_publicacion > current_year:
            raise ValueError(
                f"El año {año_publicacion} no es válido (1000–{current_year})."
            )

        self.titulo = titulo
        self.autor = autor
        self.año_publicacion = año_publicacion
        self.disponible = True

    def prestar(self) -> bool:
        if not self.disponible:
            return False
        self.disponible = False
        return True

    def devolver(self) -> None:
        self.disponible = True

    def mostrar_info(self) -> None:
        estado = "Disponible" if self.disponible else "Prestado"
        print(f"📖 Título : {self.titulo}")
        print(f"✍️ Autor  : {self.autor}")
        print(f"📅 Año    : {self.año_publicacion}")
        print(f"📌 Estado : {estado}")
        print()

    def es_clasico(self, años: int = 50) -> bool:
        return (date.today().year - self.año_publicacion) > años
