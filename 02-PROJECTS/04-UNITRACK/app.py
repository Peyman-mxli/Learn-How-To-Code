from __future__ import annotations

import os
import sqlite3
from datetime import datetime
from pathlib import Path

from flask import Flask, jsonify, redirect, render_template, request, session, url_for
from werkzeug.security import check_password_hash, generate_password_hash
from werkzeug.utils import secure_filename


BASE_DIR = Path(__file__).resolve().parent
DATABASE_PATH = BASE_DIR / "unitrack.db"
UPLOAD_FOLDER = BASE_DIR / "Static" / "uploads"
UPLOAD_FOLDER.mkdir(parents=True, exist_ok=True)

app = Flask(__name__)
app.secret_key = os.environ.get("UNITRACK_SECRET_KEY", "dev-only-change-me")

ADMIN_VERIFY_CODE = os.environ.get("UNITRACK_ADMIN_CODE")


def get_connection() -> sqlite3.Connection:
    conn = sqlite3.connect(DATABASE_PATH)
    conn.row_factory = sqlite3.Row
    return conn


def init_db() -> None:
    with get_connection() as conn:
        conn.execute(
            """
            CREATE TABLE IF NOT EXISTS users (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                username TEXT UNIQUE NOT NULL,
                nombre TEXT NOT NULL,
                apellidos TEXT NOT NULL,
                password TEXT NOT NULL,
                foto TEXT,
                rol TEXT NOT NULL,
                estado TEXT DEFAULT 'Activo'
            )
            """
        )
        conn.execute(
            """
            CREATE TABLE IF NOT EXISTS asistencia (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                user_id INTEGER NOT NULL,
                check_in TEXT NOT NULL,
                check_out TEXT,
                FOREIGN KEY(user_id) REFERENCES users(id)
            )
            """
        )


@app.route("/")
def index():
    return render_template("index.html")


@app.route("/validate_admin_code", methods=["POST"])
def validate_admin_code():
    submitted = request.form.get("code", "")
    valid = bool(ADMIN_VERIFY_CODE) and submitted == ADMIN_VERIFY_CODE
    return jsonify({"status": "valid" if valid else "invalid"})


@app.route("/register", methods=["GET", "POST"])
def register():
    if request.method == "GET":
        return render_template("register.html")

    username = request.form.get("username", "").strip()
    nombre_paterno = request.form.get("nombre_paterno", "").strip()
    nombre_materno = request.form.get("nombre_materno", "").strip()
    apellido_paterno = request.form.get("apellido_paterno", "").strip()
    apellido_materno = request.form.get("apellido_materno", "").strip()
    password = request.form.get("password", "")
    rol = request.form.get("rol", "").strip()

    required = [username, nombre_paterno, apellido_paterno, password, rol]
    if not all(required):
        return render_template("register.html", mensaje="Faltan campos obligatorios ❌")

    if rol.lower() in {"administrativo", "admin", "administrador"}:
        submitted_code = request.form.get("admin_code", "")
        if not ADMIN_VERIFY_CODE or submitted_code != ADMIN_VERIFY_CODE:
            return render_template(
                "register.html",
                mensaje="Código verificador de administrador incorrecto ❌",
            )

    nombre = " ".join(x for x in [nombre_paterno, nombre_materno] if x)
    apellidos = " ".join(x for x in [apellido_paterno, apellido_materno] if x)

    foto_filename = None
    foto_file = request.files.get("foto")
    if foto_file and foto_file.filename:
        foto_filename = secure_filename(foto_file.filename)
        if foto_filename:
            foto_file.save(UPLOAD_FOLDER / foto_filename)

    password_hash = generate_password_hash(password)

    try:
        with get_connection() as conn:
            conn.execute(
                """
                INSERT INTO users (username, nombre, apellidos, password, foto, rol)
                VALUES (?, ?, ?, ?, ?, ?)
                """,
                (username, nombre, apellidos, password_hash, foto_filename, rol),
            )
    except sqlite3.IntegrityError:
        return render_template("register.html", mensaje="Usuario ya registrado ❌")

    return redirect(url_for("login"))


@app.route("/login", methods=["GET", "POST"])
def login():
    if request.method == "GET":
        return render_template("login.html")

    username = request.form.get("username", "").strip()
    password = request.form.get("password", "")

    with get_connection() as conn:
        user = conn.execute(
            "SELECT * FROM users WHERE username = ?",
            (username,),
        ).fetchone()

    if user and check_password_hash(user["password"], password):
        session.clear()
        session["user_id"] = user["id"]
        session["rol"] = user["rol"]

        if user["rol"].lower() in {"alumno", "estudiante"}:
            return redirect(url_for("dashboard_alumno"))
        return redirect(url_for("index"))

    return render_template("login.html", mensaje="Credenciales inválidas ❌")


@app.route("/dashboard_alumno")
def dashboard_alumno():
    if "user_id" not in session:
        return redirect(url_for("login"))

    with get_connection() as conn:
        user = conn.execute(
            "SELECT * FROM users WHERE id = ?",
            (session["user_id"],),
        ).fetchone()
        asistencia = conn.execute(
            """
            SELECT * FROM asistencia
            WHERE user_id = ?
            ORDER BY id DESC
            LIMIT 1
            """,
            (session["user_id"],),
        ).fetchone()

    return render_template("dashboard_alumno.html", user=user, asistencia=asistencia)


@app.route("/check_in")
def check_in():
    if "user_id" not in session:
        return redirect(url_for("login"))

    with get_connection() as conn:
        existing = conn.execute(
            """
            SELECT 1 FROM asistencia
            WHERE user_id = ? AND check_out IS NULL
            """,
            (session["user_id"],),
        ).fetchone()

        if not existing:
            now = datetime.now().isoformat(timespec="seconds")
            conn.execute(
                "INSERT INTO asistencia (user_id, check_in) VALUES (?, ?)",
                (session["user_id"], now),
            )

    return redirect(url_for("dashboard_alumno"))


@app.route("/check_out")
def check_out():
    if "user_id" not in session:
        return redirect(url_for("login"))

    now = datetime.now().isoformat(timespec="seconds")
    with get_connection() as conn:
        conn.execute(
            """
            UPDATE asistencia
            SET check_out = ?
            WHERE user_id = ? AND check_out IS NULL
            """,
            (now, session["user_id"]),
        )

    return redirect(url_for("dashboard_alumno"))


@app.route("/forgot_password", methods=["GET", "POST"])
def forgot_password():
    if request.method == "POST":
        return "Password recovery is not implemented in this educational version."
    return render_template("forgot_password.html")


@app.route("/logout")
def logout():
    session.clear()
    return redirect(url_for("index"))


if __name__ == "__main__":
    init_db()
    debug = os.environ.get("FLASK_DEBUG", "0") == "1"
    app.run(debug=debug)
