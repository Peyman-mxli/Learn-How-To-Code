from .vehiculo import Vehiculo


class Bicicleta(Vehiculo):
    """Clase que representa una bicicleta"""

    def __init__(self, marca: str, modelo: str, año: int,
                 tipo: str, numero_velocidades: int):

        super().__init__(marca, modelo, año)

        self._tipo = tipo
        self._numero_velocidades = numero_velocidades
        self._velocidad_actual_cambio = 1

    def cambiar_velocidad(self, nueva_vel: int) -> None:
        """Cambia la velocidad de la bicicleta"""

        if 0 < nueva_vel <= self._numero_velocidades:
            self._velocidad_actual_cambio = nueva_vel
            print(f"Cambio ajustado a velocidad {nueva_vel}")
        else:
            print("❌ Velocidad inválida")

    def tocar_timbre(self) -> None:
        """Hace sonar el timbre"""

        print("🔔 Ring ring!")

    def obtener_informacion(self) -> str:
        """Información completa de la bicicleta"""

        return (f"{self._marca} {self._modelo} ({self._año}) | "
                f"Tipo: {self._tipo} | "
                f"Cambios: {self._numero_velocidades} | "
                f"Vel: {self._velocidad_actual} km/h")