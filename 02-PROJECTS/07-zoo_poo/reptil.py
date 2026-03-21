from animal import Animal

class Reptil(Animal):
    """Representa un reptil del zoológico."""

    def __init__(self, nombre, especie, edad, peso,
                 tipo_piel: str, es_venenoso: bool):
        super().__init__(nombre, especie, edad, peso)
        self._tipo_piel = tipo_piel
        self._es_venenoso = es_venenoso

    def hacer_sonido(self) -> str:
        return "Ssssss..."

    def tipo_alimentacion(self) -> str:
        return "Carnívoro 🍖"

    def mudar_piel(self) -> None:
        print(f"{self.nombre} está mudando su piel ({self._tipo_piel})")