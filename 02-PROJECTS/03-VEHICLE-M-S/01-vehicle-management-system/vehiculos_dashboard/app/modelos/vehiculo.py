from abc import ABC, abstractmethod

class Vehiculo(ABC):
    """
    Clase abstracta base para todos los vehículos.
    No se puede crear directamente.
    """

    def __init__(self, marca: str, modelo: str, año: int):

        self._marca = marca
        self._modelo = modelo
        self._año = año
        self._velocidad_actual = 0.0

    def acelerar(self) -> None:
        """Aumenta la velocidad en 10 km/h"""

        self._velocidad_actual += 10
        print(f"Acelerando... Velocidad actual: {self._velocidad_actual} km/h")

    def frenar(self) -> None:
        """Reduce la velocidad en 10 km/h"""

        if self._velocidad_actual >= 10:
            self._velocidad_actual -= 10
        else:
            self._velocidad_actual = 0

        print(f"Frenando... Velocidad actual: {self._velocidad_actual} km/h")

    @abstractmethod
    def obtener_informacion(self) -> str:
        """
        Método abstracto obligatorio para las clases hijas.
        """
        pass