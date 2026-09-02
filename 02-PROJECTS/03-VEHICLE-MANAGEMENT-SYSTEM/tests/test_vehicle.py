import unittest

from app.modelos import Automovil


class VehicleTests(unittest.TestCase):
    def test_speed_property_tracks_acceleration_and_braking(self):
        vehicle = Automovil("Toyota", "Corolla", 2023, 4, "Automática")

        self.assertEqual(vehicle.velocidad_actual, 0.0)

        vehicle.acelerar()
        self.assertEqual(vehicle.velocidad_actual, 10.0)

        vehicle.frenar()
        self.assertEqual(vehicle.velocidad_actual, 0.0)

    def test_braking_never_produces_negative_speed(self):
        vehicle = Automovil("Toyota", "Corolla", 2023, 4, "Automática")

        vehicle.frenar()

        self.assertEqual(vehicle.velocidad_actual, 0.0)


if __name__ == "__main__":
    unittest.main()
