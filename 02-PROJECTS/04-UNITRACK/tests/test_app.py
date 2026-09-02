import importlib.util
import tempfile
import unittest
from pathlib import Path

MODULE_PATH = Path(__file__).resolve().parents[1] / "app.py"
SPEC = importlib.util.spec_from_file_location("unitrack_app", MODULE_PATH)
module = importlib.util.module_from_spec(SPEC)
assert SPEC.loader is not None
SPEC.loader.exec_module(module)

class UniTrackSmokeTests(unittest.TestCase):
    def setUp(self):
        self.tempdir = tempfile.TemporaryDirectory()
        module.DATABASE_PATH = Path(self.tempdir.name) / "unitrack-test.db"
        module.app.template_folder = str(MODULE_PATH.parent / "templates")
        module.app.static_folder = str(MODULE_PATH.parent / "static")
        module.app.config.update(TESTING=True, SECRET_KEY="test-secret")
        module.init_db()
        self.client = module.app.test_client()

    def tearDown(self):
        self.tempdir.cleanup()

    def test_home_page(self):
        response = self.client.get("/")
        self.assertEqual(response.status_code, 200)

    def test_login_page(self):
        response = self.client.get("/login")
        self.assertEqual(response.status_code, 200)

    def test_unauthenticated_dashboard_redirects(self):
        response = self.client.get("/dashboard_alumno")
        self.assertEqual(response.status_code, 302)
        self.assertIn("/login", response.headers["Location"])

if __name__ == "__main__":
    unittest.main()
