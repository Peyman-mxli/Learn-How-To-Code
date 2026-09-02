from app.modelos import Automovil, Bicicleta, Camion, Motocicleta


def reporte_flota(vehiculos: list) -> None:
    """Procesa y muestra un reporte general de la flota."""
    print("\n=== REPORTE DE FLOTA ===")

    for vehiculo in vehiculos:
        if isinstance(vehiculo, Camion):
            vehiculo.cargar(5)

        for _ in range(3):
            vehiculo.acelerar()

        print(vehiculo.obtener_informacion())

        while vehiculo.velocidad_actual > 0:
            vehiculo.frenar()

    print(f"\nTotal de vehículos procesados: {len(vehiculos)}")


def main() -> None:
    print("=" * 55)
    print("     SISTEMA DE GESTIÓN DE VEHÍCULOS")
    print("=" * 55)

    auto = Automovil("Toyota", "Corolla", 2023, 4, "Automática")
    moto = Motocicleta("Yamaha", "R6", 2022, 600)
    camion = Camion("Volvo", "FH16", 2021, 25.0, 3)
    bici = Bicicleta("Trek", "X-Caliber", 2024, "montaña", 12)

    print("\n=== AUTOMÓVIL ===")
    auto.acelerar()
    auto.encender_luces()
    print(auto.obtener_informacion())

    print("\n=== MOTOCICLETA ===")
    moto.acelerar()
    moto.levantar_caballete()
    moto.hacer_caballito()
    print(moto.obtener_informacion())

    print("\n=== CAMIÓN ===")
    camion.cargar(5)
    camion.cargar(10)
    camion.cargar(10)
    camion.acelerar()
    print(camion.obtener_informacion())
    camion.descargar()

    reporte_flota([auto, moto, camion, bici])


if __name__ == "__main__":
    main()
