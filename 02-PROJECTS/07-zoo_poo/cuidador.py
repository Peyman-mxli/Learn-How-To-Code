class Cuidador:
    """Representa a un cuidador del zoológico."""

    def __init__(self, nombre: str, id_cuidador: str, especialidad: str):
        self.nombre       = nombre
        self.id_cuidador  = id_cuidador
        self.especialidad = especialidad

    def alimentar(self, animal) -> None:
        print(f"🍽️  {self.nombre} alimenta a {animal.nombre}")
        print(f"   Dieta: {animal.tipo_alimentacion()}")

    def revisar_salud(self, animal, nuevo_estado: str) -> None:
        print(f"🩺 {self.nombre} revisa a {animal.nombre}...")
        actualizado = animal.actualizar_salud(nuevo_estado)
        if actualizado:
            print(f"   Estado actualizado: {animal.get_estado_salud()}")

    def mostrar_perfil(self) -> None:
        print(f"👤 Cuidador: {self.nombre} | ID: {self.id_cuidador} | Esp: {self.especialidad}")