class Libro:
    """Representa un libro en la biblioteca."""

    def __init__(self, titulo: str, autor: str, año_publicacion: int):

        if not titulo or titulo.strip() == "":
            print("❌ Error: el título no puede estar vacío.")

        if not autor or autor.strip() == "":
            print("❌ Error: el autor no puede estar vacío.")

        if año_publicacion < 1000 or año_publicacion > 2025:
            print(f"❌ Error: el año {año_publicacion} no es válido (1000–2025).")

        self.titulo = titulo
        self.autor = autor
        self.año_publicacion = año_publicacion
        self.disponible = True

    def prestar(self):
        if self.disponible:
            self.disponible = False
            print(f'✓ El libro "{self.titulo}" ha sido prestado.')
        else:
            print(f'✗ El libro "{self.titulo}" ya está prestado.')

    def devolver(self):
        self.disponible = True
        print(f'✓ El libro "{self.titulo}" ha sido devuelto.')

    def mostrar_info(self):
        estado = "Disponible" if self.disponible else "Prestado"

        print(f"📖 Título : {self.titulo}")
        print(f"✍️ Autor  : {self.autor}")
        print(f"📅 Año    : {self.año_publicacion}")
        print(f"📌 Estado : {estado}")
        print()

    def es_clasico(self):
        return (2025 - self.año_publicacion) > 50