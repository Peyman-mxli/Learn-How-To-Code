class Animal:

    def __init__(self, nombre, edad, peso, dueno, codigo):
        self._nombre = nombre
        self._edad = edad
        self._peso = peso
        self._dueno = dueno
        self._codigo = codigo
        self._vacunado = False
        self._historial_consultas = []

    # Getters
    def get_nombre(self):
        return self._nombre

    def get_edad(self):
        return self._edad

    def get_peso(self):
        return self._peso

    def get_dueno(self):
        return self._dueno

    def get_codigo(self):
        return self._codigo

    def esta_vacunado(self):
        return self._vacunado

    def get_historial(self):
        return self._historial_consultas

    # Acciones
    def vacunar(self):
        if not self._vacunado:
            self._vacunado = True
            print(f"{self._nombre} ha sido vacunado.")
        else:
            print(f"{self._nombre} ya estaba vacunado.")

    def agregar_consulta(self, motivo):
        self._historial_consultas.append(motivo)
        print(f"Consulta agregada para {self._nombre}: {motivo}")

    def cambiar_peso(self, nuevo_peso):
        self._peso = nuevo_peso
        print(f"El nuevo peso de {self._nombre} es {self._peso} kg.")

    def contar_consultas(self):
        return len(self._historial_consultas)

    # Polimorfismo
    def hacer_sonido(self):
        return "El animal hace un sonido."

    def mostrar_info(self):
        return f"""
Nombre: {self._nombre}
Edad: {self._edad}
Peso: {self._peso}
Dueño: {self._dueno}
Vacunado: {self._vacunado}
"""