from mamifero  import Mamifero
from ave       import Ave
from reptil    import Reptil
from cuidador  import Cuidador
from zoologico import Zoologico

def main():
    print("=" * 55)
    print("   🦁 SISTEMA DE GESTIÓN DE ZOOLÓGICO")
    print("=" * 55)

    # ── TODO 1: Crear el zoológico
    zoo = Zoologico("Zoológico Municipal")

    # ── TODO 2: Crear al menos 3 animales
    leon     = Mamifero("Simba", "León", 5, 180.0, "dorado", False)
    tucan    = Ave("Pico", "Tucán", 3, 0.6, 50, True)
    boa      = Reptil("Sly", "Boa constrictor", 2, 12.5, "escamosa", False)

    # ── TODO 3: Crear 2 cuidadores
    cuidador1 = Cuidador("Ana", "C001", "Mamíferos")
    cuidador2 = Cuidador("Luis", "C002", "Aves y Reptiles")

    # ── TODO 4: Agregar todo al zoológico
    zoo.agregar_animal(leon)
    zoo.agregar_animal(tucan)
    zoo.agregar_animal(boa)
    zoo.agregar_cuidador(cuidador1)
    zoo.agregar_cuidador(cuidador2)

    # ── TODO 5: Encapsulamiento
    print(f"\nSalud de {leon.nombre}: {leon.get_estado_salud()}")
    cuidador1.revisar_salud(leon, "en tratamiento")
    leon.actualizar_salud("zombie")   # muestra error

    # ── TODO 6: Polimorfismo
    print("\n🎭 Polimorfismo — todos los animales hacen su sonido:")
    for animal in [leon, tucan, boa]:
        print(f"  {animal.nombre}: {animal.hacer_sonido()}")

    # ── TODO 7: Hacer tour
    zoo.hacer_tour()

    # ── TODO 8: Reporte general
    zoo.reporte_general()

if __name__ == "__main__":
    main()