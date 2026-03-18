from flask import Flask, render_template, request, redirect, url_for, session, jsonify
import sqlite3
from datetime import datetime
import os

app = Flask(__name__)
app.secret_key = "supersecretkey"

UPLOAD_FOLDER = "static/uploads"
os.makedirs(UPLOAD_FOLDER, exist_ok=True)

# 🔐 ADMIN VERIFICATION CODE (Later we make this dynamic)
ADMIN_VERIFY_CODE = "UPBC2026"


# ---------------- HOME (INDEX PAGE) ----------------
@app.route("/")
def index():
    return render_template("index.html")


# ---------------- DATABASE ----------------
def init_db():
    conn = sqlite3.connect("unitrack.db")
    cursor = conn.cursor()

    cursor.execute("""
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
    """)

    cursor.execute("""
        CREATE TABLE IF NOT EXISTS asistencia (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            user_id INTEGER,
            check_in TEXT,
            check_out TEXT,
            FOREIGN KEY(user_id) REFERENCES users(id)
        )
    """)

    conn.commit()
    conn.close()


# ---------------- VALIDATE ADMIN CODE (AJAX) ----------------
@app.route("/validate_admin_code", methods=["POST"])
def validate_admin_code():
    code = request.form.get("code")

    if code == ADMIN_VERIFY_CODE:
        return jsonify({"status": "valid"})
    else:
        return jsonify({"status": "invalid"})


# ---------------- REGISTER ----------------
@app.route("/register", methods=["GET", "POST"])
def register():
    if request.method == "POST":

        admin_code = request.form.get("admin_code")

        if admin_code != ADMIN_VERIFY_CODE:
            return render_template("register.html",
                                   mensaje="Código verificador de administrador es incorrecto ❌")

        username = request.form.get("username")

        # Combine names properly
        nombre_paterno = request.form.get("nombre_paterno")
        nombre_materno = request.form.get("nombre_materno")
        apellido_paterno = request.form.get("apellido_paterno")
        apellido_materno = request.form.get("apellido_materno")

        if not all([username, nombre_paterno, nombre_materno,
                    apellido_paterno, apellido_materno]):
            return render_template("register.html",
                                   mensaje="Faltan campos obligatorios ❌")

        nombre = f"{nombre_paterno} {nombre_materno}"
        apellidos = f"{apellido_paterno} {apellido_materno}"

        password = request.form.get("password")
        rol = request.form.get("rol")

        foto_file = request.files.get("foto")
        foto_filename = None

        if foto_file and foto_file.filename != "":
            foto_filename = foto_file.filename
            foto_path = os.path.join(UPLOAD_FOLDER, foto_filename)
            foto_file.save(foto_path)

        conn = sqlite3.connect("unitrack.db")
        cursor = conn.cursor()

        try:
            cursor.execute("""
                INSERT INTO users (username, nombre, apellidos, password, foto, rol)
                VALUES (?, ?, ?, ?, ?, ?)
            """, (username, nombre, apellidos, password, foto_filename, rol))

            conn.commit()

        except sqlite3.IntegrityError:
            conn.close()
            return render_template("register.html",
                                   mensaje="Usuario ya registrado ❌")

        conn.close()
        return redirect(url_for("login"))

    return render_template("register.html")
# ---------------- LOGIN ----------------
@app.route("/login", methods=["GET", "POST"])
def login():
    if request.method == "POST":

        username = request.form.get("username")
        password = request.form.get("password")

        conn = sqlite3.connect("unitrack.db")
        cursor = conn.cursor()

        cursor.execute(
            "SELECT * FROM users WHERE username=? AND password=?",
            (username, password)
        )

        user = cursor.fetchone()
        conn.close()

        if user:
            session["user_id"] = user[0]
            session["rol"] = user[6]

            if user[6] == "Alumno":
                return redirect(url_for("dashboard_alumno"))
            else:
                return redirect(url_for("index"))

        return render_template("login.html",
                               mensaje="Credenciales inválidas ❌")

    return render_template("login.html")


# ---------------- DASHBOARD ALUMNO ----------------
@app.route("/dashboard_alumno")
def dashboard_alumno():
    if "user_id" not in session:
        return redirect(url_for("login"))

    conn = sqlite3.connect("unitrack.db")
    cursor = conn.cursor()

    cursor.execute("SELECT * FROM users WHERE id=?",
                   (session["user_id"],))
    user = cursor.fetchone()

    cursor.execute("""
        SELECT * FROM asistencia
        WHERE user_id=?
        ORDER BY id DESC LIMIT 1
    """, (session["user_id"],))

    asistencia = cursor.fetchone()

    conn.close()

    return render_template("dashboard_alumno.html",
                           user=user,
                           asistencia=asistencia)


# ---------------- CHECK IN ----------------
@app.route("/check_in")
def check_in():
    if "user_id" not in session:
        return redirect(url_for("login"))

    conn = sqlite3.connect("unitrack.db")
    cursor = conn.cursor()

    cursor.execute("""
        SELECT * FROM asistencia
        WHERE user_id=? AND check_out IS NULL
    """, (session["user_id"],))

    existing = cursor.fetchone()

    if not existing:
        now = datetime.now().strftime("%d/%m/%Y %H:%M:%S")

        cursor.execute("""
            INSERT INTO asistencia (user_id, check_in)
            VALUES (?, ?)
        """, (session["user_id"], now))

        conn.commit()

    conn.close()
    return redirect(url_for("dashboard_alumno"))


# ---------------- CHECK OUT ----------------
@app.route("/check_out")
def check_out():
    if "user_id" not in session:
        return redirect(url_for("login"))

    conn = sqlite3.connect("unitrack.db")
    cursor = conn.cursor()

    now = datetime.now().strftime("%d/%m/%Y %H:%M:%S")

    cursor.execute("""
        UPDATE asistencia
        SET check_out=?
        WHERE user_id=? AND check_out IS NULL
    """, (now, session["user_id"]))

    conn.commit()
    conn.close()

    return redirect(url_for("dashboard_alumno"))


# ---------------- FORGOT PASSWORD ----------------
@app.route("/forgot_password", methods=["GET", "POST"])
def forgot_password():
    if request.method == "POST":
        email = request.form.get("email")
        return "Código enviado al correo (simulado)."

    return render_template("forgot_password.html")


# ---------------- LOGOUT ----------------
@app.route("/logout")
def logout():
    session.clear()
    return redirect(url_for("index"))


if __name__ == "__main__":
    init_db()
    app.run(debug=True)