import importlib.util
import unittest
from pathlib import Path

MODULE_PATH = Path(__file__).resolve().parents[1] / "main.py"
SPEC = importlib.util.spec_from_file_location("calculator_main", MODULE_PATH)
module = importlib.util.module_from_spec(SPEC)
assert SPEC.loader is not None
SPEC.loader.exec_module(module)

class CalculatorTests(unittest.TestCase):
    def test_add(self):
        self.assertEqual(module.add(2, 3), 5)

    def test_subtract(self):
        self.assertEqual(module.subtract(10, 4), 6)

    def test_multiply(self):
        self.assertEqual(module.multiply(3, 4), 12)

    def test_divide(self):
        self.assertEqual(module.divide(8, 2), 4)

    def test_divide_by_zero(self):
        with self.assertRaises(ZeroDivisionError):
            module.divide(1, 0)

if __name__ == "__main__":
    unittest.main()
