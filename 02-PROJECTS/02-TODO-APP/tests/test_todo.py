import importlib.util
import unittest
from pathlib import Path

MODULE_PATH = Path(__file__).resolve().parents[1] / "main.py"
SPEC = importlib.util.spec_from_file_location("todo_main", MODULE_PATH)
module = importlib.util.module_from_spec(SPEC)
assert SPEC.loader is not None
SPEC.loader.exec_module(module)

class TodoTests(unittest.TestCase):
    def setUp(self):
        self.tasks = []

    def test_add_task(self):
        module.add_task(self.tasks, "Study")
        self.assertEqual(self.tasks[0]["title"], "Study")
        self.assertFalse(self.tasks[0]["completed"])

    def test_reject_empty_title(self):
        with self.assertRaises(ValueError):
            module.add_task(self.tasks, "   ")

    def test_complete_task(self):
        module.add_task(self.tasks, "Study")
        module.complete_task(self.tasks, 0)
        self.assertTrue(self.tasks[0]["completed"])

    def test_delete_task(self):
        module.add_task(self.tasks, "Study")
        module.delete_task(self.tasks, 0)
        self.assertEqual(self.tasks, [])

    def test_invalid_index(self):
        with self.assertRaises(IndexError):
            module.complete_task(self.tasks, 0)

if __name__ == "__main__":
    unittest.main()
