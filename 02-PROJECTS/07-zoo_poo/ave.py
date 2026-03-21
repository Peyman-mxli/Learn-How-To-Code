from animal import Animal

class Ave(Animal):
    """Representa un ave del zoológico."""

    def __init__(self, nombre, especie, edad, peso,
                 envergadura: float, puede_volar: bool):
        super().__init__(nombre, especie, edad, peso)
        self._envergadura = envergadura
        self._puede_volar = puede_volar

    def hacer_sonido(self) -> str:
        return "Toc toc toc 🐦"

    def tipo_alimentacion(self) -> str:
        return "Frugívoro 🌿" if self.especie.lower() in ["tucán", "loro"] else "Omnívoro 🍽️"

    def volar(self) -> None:
        if self._puede_volar:
            print(f"{self.nombre} está volando con alas de {self._envergadura} cm")
        else:
            print(f"{self.nombre} no puede volar")