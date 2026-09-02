import unittest

from animal import Animal
from ave import Ave
from gato import Gato
from perro import Perro


class VeterinaryTests(unittest.TestCase):
    def test_vaccination_changes_state(self):
        animal = Animal("Luna", 2, 8.5, "Ana", "A001")
        self.assertFalse(animal.esta_vacunado())
        animal.vacunar()
        self.assertTrue(animal.esta_vacunado())

    def test_consultation_history(self):
        animal = Animal("Luna", 2, 8.5, "Ana", "A001")
        animal.agregar_consulta("Revisión anual")
        self.assertEqual(animal.contar_consultas(), 1)
        self.assertEqual(animal.get_historial(), ["Revisión anual"])

    def test_polymorphic_sounds(self):
        perro = Perro("Max", 3, 12, "Ana", "P001", "Labrador")
        gato = Gato("Mia", 2, 4, "Luis", "G001", "gris", True)
        ave = Ave("Pico", 1, 0.5, "Eva", "A001", "loro", True, "mediana")
        self.assertIn("Guau", perro.hacer_sonido())
        self.assertIn("Miau", gato.hacer_sonido())
        self.assertIn("Pío", ave.hacer_sonido())

    def test_weight_can_be_updated(self):
        animal = Animal("Luna", 2, 8.5, "Ana", "A001")
        animal.cambiar_peso(9.0)
        self.assertEqual(animal.get_peso(), 9.0)


if __name__ == "__main__":
    unittest.main()
