from abc import ABC, abstractmethod


class Vehiculo(ABC):
    """Clase abstracta base para todos los vehículos."""

    def __init__(self, marca: str, modelo: str, año: int):
        self._marca = marca
        self._modelo = modelo
        self._año = año
        self._velocidad_actual = 0.0

    @property
    def velocidad_actual(self) -> float:
        """Velocidad actual de solo lectura, expresada en km/h."""
        return self._velocidad_actual

    def acelerar(self) -> None:
        """Aumenta la velocidad en 10 km/h."""
        self._velocidad_actual += 10
        print(f"Acelerando... Velocidad actual: {self._velocidad_actual} km/h")

    def frenar(self) -> None:
        """Reduce la velocidad en 10 km/h sin bajar de cero."""
        self._velocidad_actual = max(0.0, self._velocidad_actual - 10)
        print(f"Frenando... Velocidad actual: {self._velocidad_actual} km/h")

    @abstractmethod
    def obtener_informacion(self) -> str:
        """Devuelve una descripción del vehículo."""
        raise NotImplementedError
