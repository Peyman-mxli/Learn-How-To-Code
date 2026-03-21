from abc import ABC, abstractmethod

class Animal(ABC):
    """Clase abstracta base para todos los animales del zoológico."""

    ESTADOS_VALIDOS = ["sano", "enfermo", "en tratamiento", "grave"]

    def __init__(self, nombre: str, especie: str, edad: int, peso: float):
        self.nombre  = nombre
        self.especie = especie
        self.edad    = edad
        self.peso    = peso
        self._estado_salud = "sano"

    @abstractmethod
    def hacer_sonido(self) -> str:
        pass

    @abstractmethod
    def tipo_alimentacion(self) -> str:
        pass

    def get_estado_salud(self) -> str:
        return self._estado_salud

    def actualizar_salud(self, nuevo_estado: str) -> bool:
        if nuevo_estado in Animal.ESTADOS_VALIDOS:
            self._estado_salud = nuevo_estado
            return True
        print(f"❌ Estado '{nuevo_estado}' no válido.")
        return False

    def mostrar_info(self) -> None:
        print(f"  🐾 {self.nombre} ({self.especie})")
        print(f"     Edad: {self.edad} años | Peso: {self.peso} kg")
        print(f"     Salud: {self._estado_salud}")
        print(f"     Sonido: {self.hacer_sonido()}")
        print(f"     Dieta: {self.tipo_alimentacion()}")