from animal import Animal


class Perro(Animal):

    def __init__(self, nombre, edad, peso, dueno, codigo, raza):
        super().__init__(nombre, edad, peso, dueno, codigo)
        self._raza = raza
        self._adiestrado = False

    # Metodo especial
    def adiestrar(self):
        self._adiestrado = True
        print(f"{self._nombre} ahora está adiestrado.")

    def pasear(self):
        if self._edad > 0.5:
            print(f"{self._nombre} salió a pasear 🐕")
        else:
            print(f"{self._nombre} es muy pequeño para pasear.")

    # Polimorfismo
    def hacer_sonido(self):
        return f"{self._nombre} dice: ¡Guau guau!"

    def mostrar_info(self):
        return f"""
Tipo: Perro
Nombre: {self._nombre}
Edad: {self._edad}
Peso: {self._peso}
Dueño: {self._dueno}
Raza: {self._raza}
Adiestrado: {self._adiestrado}
Vacunado: {self._vacunado}

"""
print("HELLO FROM MAIN")