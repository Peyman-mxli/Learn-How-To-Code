import unittest

from animal import Animal
from ave import Ave
from cuidador import Cuidador
from mamifero import Mamifero
from zoologico import Zoologico


class ZooTests(unittest.TestCase):
    def test_abstract_animal_cannot_be_instantiated(self):
        with self.assertRaises(TypeError):
            Animal("Test", "Unknown", 1, 1.0)

    def test_invalid_health_state_is_rejected(self):
        animal = Mamifero("Simba", "León", 5, 180.0, "dorado", False)
        self.assertFalse(animal.actualizar_salud("zombie"))
        self.assertEqual(animal.get_estado_salud(), "sano")

    def test_valid_health_state_is_applied(self):
        animal = Mamifero("Simba", "León", 5, 180.0, "dorado", False)
        self.assertTrue(animal.actualizar_salud("en tratamiento"))
        self.assertEqual(animal.get_estado_salud(), "en tratamiento")

    def test_polymorphism_across_animal_types(self):
        leon = Mamifero("Simba", "León", 5, 180.0, "dorado", False)
        tucan = Ave("Pico", "Tucán", 3, 0.6, 50, True)
        sounds = [animal.hacer_sonido() for animal in (leon, tucan)]
        self.assertEqual(len(sounds), 2)
        self.assertTrue(all(isinstance(sound, str) and sound for sound in sounds))

    def test_zoo_registration(self):
        zoo = Zoologico("Municipal")
        animal = Mamifero("Simba", "León", 5, 180.0, "dorado", False)
        cuidador = Cuidador("Ana", "C001", "Mamíferos")
        zoo.agregar_animal(animal)
        zoo.agregar_cuidador(cuidador)
        self.assertEqual(len(zoo._animales), 1)
        self.assertEqual(len(zoo._cuidadores), 1)


if __name__ == "__main__":
    unittest.main()
