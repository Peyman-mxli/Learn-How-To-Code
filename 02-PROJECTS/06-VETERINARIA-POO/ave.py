from animal import Animal


class Ave(Animal):

    def __init__(self, nombre, edad, peso, dueno, codigo, especie, puede_volar, tamano_jaula):
        super().__init__(nombre, edad, peso, dueno, codigo)
        self._especie = especie
        self._puede_volar = puede_volar
        self._tamano_jaula = tamano_jaula

    # Metodo especial
    def cortar_plumas(self):
        if self._puede_volar:
            self._puede_volar = False
            print(f"A {self._nombre} se le han cortado las plumas. Ya no puede volar.")
        else:
            print(f"{self._nombre} ya no puede volar.")

    def entrenar_habla(self):
        if self._especie.lower() == "loro":
            print(f"{self._nombre} está aprendiendo a hablar 🦜")
        else:
            print(f"{self._nombre} no puede aprender a hablar porque no es un loro.")

    # Polimorfismo
    def hacer_sonido(self):
        return f"{self._nombre} dice: Pío pío 🐦"

    def mostrar_info(self):
        return f"""
Tipo: Ave
Nombre: {self._nombre}
Edad: {self._edad}
Peso: {self._peso}
Dueño: {self._dueno}
Especie: {self._especie}
Puede volar: {self._puede_volar}
Tamaño de jaula: {self._tamano_jaula}
Vacunado: {self._vacunado}
"""