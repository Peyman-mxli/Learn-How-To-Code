from animal import Animal


class Gato(Animal):

    def __init__(self, nombre, edad, peso, dueno, codigo, color, es_interior):
        super().__init__(nombre, edad, peso, dueno, codigo)
        self._color = color
        self._es_interior = es_interior

    def cambiar_ambiente(self):
        self._es_interior = not self._es_interior

        if self._es_interior:
            print(f"{self._nombre} ahora vive dentro de la casa.")
        else:
            print(f"{self._nombre} ahora vive fuera de la casa.")

    def cortar_unas(self):
        if self._es_interior:
            print(f"Las uñas de {self._nombre} han sido cortadas.")
        else:
            print(f"No se pueden cortar las uñas de {self._nombre} porque vive afuera.")

    def hacer_sonido(self):
        return f"{self._nombre} dice: Miau 🐱"

    def mostrar_info(self):
        return f"""
Tipo: Gato
Nombre: {self._nombre}
Edad: {self._edad}
Peso: {self._peso}
Dueño: {self._dueno}
Color: {self._color}
Vive en interior: {self._es_interior}
Vacunado: {self._vacunado}
"""