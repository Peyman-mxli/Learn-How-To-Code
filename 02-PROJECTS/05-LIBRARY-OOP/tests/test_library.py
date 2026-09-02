import unittest
from datetime import date

from models.libro import Libro
from services.biblioteca import Biblioteca


class LibroTests(unittest.TestCase):
    def test_new_book_is_available(self):
        libro = Libro("Clean Code", "Robert C. Martin", 2008)
        self.assertTrue(libro.disponible)

    def test_empty_title_is_rejected(self):
        with self.assertRaises(ValueError):
            Libro("   ", "Author", 2020)

    def test_future_year_is_rejected(self):
        with self.assertRaises(ValueError):
            Libro("Future Book", "Author", date.today().year + 1)

    def test_lend_and_return(self):
        libro = Libro("1984", "George Orwell", 1949)
        self.assertTrue(libro.prestar())
        self.assertFalse(libro.disponible)
        self.assertFalse(libro.prestar())
        libro.devolver()
        self.assertTrue(libro.disponible)


class BibliotecaTests(unittest.TestCase):
    def setUp(self):
        self.biblioteca = Biblioteca("Central")
        self.libro = Libro("The Hobbit", "J. R. R. Tolkien", 1937)
        self.biblioteca.agregar_libro(self.libro)

    def test_search_is_case_insensitive(self):
        self.assertIs(self.biblioteca.buscar_por_titulo("the hobbit"), self.libro)

    def test_available_books(self):
        self.assertEqual(self.biblioteca.libros_disponibles(), [self.libro])
        self.libro.prestar()
        self.assertEqual(self.biblioteca.libros_disponibles(), [])


if __name__ == "__main__":
    unittest.main()
