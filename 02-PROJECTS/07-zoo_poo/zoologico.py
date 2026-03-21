class Zoologico:
    """Gestiona la colección de animales y cuidadores."""

    def __init__(self, nombre: str):
        self.nombre      = nombre
        self._animales   = []
        self._cuidadores = []

    def agregar_animal(self, animal) -> None:
        self._animales.append(animal)
        print(f"✅ {animal.nombre} agregado al zoológico.")

    def agregar_cuidador(self, cuidador) -> None:
        self._cuidadores.append(cuidador)
        print(f"✅ Cuidador {cuidador.nombre} registrado.")

    def hacer_tour(self) -> None:
        print(f"\n{'='*50}")
        print(f"  🦁 Tour virtual — {self.nombre}")
        print(f"{'='*50}")
        for i, animal in enumerate(self._animales, 1):
            print(f"\n  Animal #{i}:")
            animal.mostrar_info()

    def reporte_general(self) -> None:
        print(f"\n📊 Reporte — {self.nombre}")
        print(f"   Total animales : {len(self._animales)}")
        print(f"   Total cuidadores: {len(self._cuidadores)}")
        sanos = sum(1 for a in self._animales if a.get_estado_salud() == "sano")
        print(f"   Animales sanos : {sanos}/{len(self._animales)}")