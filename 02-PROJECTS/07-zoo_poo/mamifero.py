from animal import Animal

class Mamifero(Animal):
    """Representa un mamífero del zoológico."""

    def __init__(self, nombre, especie, edad, peso,
                 color_pelaje: str, es_domestico: bool):
        super().__init__(nombre, especie, edad, peso)
        self._color_pelaje = color_pelaje
        self._es_domestico = es_domestico

    def hacer_sonido(self) -> str:
        return "Roar!" if not self._es_domestico else "Miau 🐾"

    def tipo_alimentacion(self) -> str:
        # ejemplo simple, se puede personalizar según especie
        return "Carnívoro 🍖" if self.especie.lower() in ["león", "tigre", "boa"] else "Omnívoro 🍽️"

    def amamantar(self) -> None:
        msg = f"{self.nombre} está amamantando a sus crías"
        if not self._es_domestico:
            msg += " en estado salvaje"
        print(msg)