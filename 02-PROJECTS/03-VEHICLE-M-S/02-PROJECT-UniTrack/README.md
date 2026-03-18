# 🧵 Project — UniTrack (Sistema de Control de Asistencia)
=======================================
# ✨ Overview
=============================================================================
**UniTrack** es un sistema web para el registro y control de asistencia
universitaria, desarrollado con Python y Flask.
La aplicación permite gestionar el acceso de:
estudiantes, docentes, trabajadores y administradores,
registrando automáticamente las entradas y salidas
en una base de datos segura.
Este proyecto fue desarrollado como parte de un proyecto universitario,
con el objetivo de convertirse en un producto real escalable.
=============================================================================
🎓 Universidad
Universidad Politécnica de Baja California (UPBC)
Programa:
Ingeniería en Tecnologías de la Información e Innovación Digital
Año:
2026
=============================================================================
🎯 Objetivo del Proyecto
El objetivo principal del sistema es mejorar la seguridad institucional
y automatizar el control de asistencia, reemplazando métodos manuales
o sistemas poco integrados.
El sistema permite:
Registrar usuarios  
Autenticar accesos  
Controlar entradas y salidas  
Administrar usuarios  
Supervisar asistencia en tiempo real  
=============================================================================

📦 Tecnologías Utilizadas
Backend
Python  
Flask  
SQLAlchemy  
Flask-Login  
Werkzeug Security (Password Hashing)  
=
Frontend
HTML5  
CSS3  
Bootstrap 5  
Base de Datos
SQLite (versión actual)  
Preparado para migración futura a PostgreSQL  
=============================================================================
# 🏗️ Arquitectura del Sistema
El sistema sigue una arquitectura Web Application basada en Flask.
Componentes principales:
# Backend
Flask Application Server  
SQLAlchemy ORM  
Authentication System  
Role-Based Access Control (RBAC)  

# Frontend
HTML Templates  
CSS Styling  
Bootstrap Responsive Layout  
Database
SQLite local database  

=============================================================================

# 📂 Estructura del Proyecto

```plaintext
Unitrack/
│
├── app.py
├── unitrack.db
├── README.md
│
├── templates/
│   ├── base.html
│   ├── index.html
│   ├── login.html
│   ├── register.html
│   └── dashboard.html
│
├── static/
│   ├── css/
│   │   └── style.css
│   │
│   └── images/
│       ├── background.png
│       └── logo.png
│
└── venv/
=============================================================================
# ⚙️ Funcionalidades del Sistema
# 📌 Registro de Usuarios
Los usuarios pueden registrarse con:
Nombre(s)
Apellido(s)
Nombre de usuario
Contraseña
Confirmación de contraseña
CURP
Fotografía
Número de celular (opcional)
Correo electrónico (opcional)
Rol de usuario

Roles disponibles:
Estudiante
Docente
Trabajador
Administrativo (requiere validación)

# 🔐 Sistema de Validación Administrativa
Para registrar cuentas administrativas:
Código de Validación del Administrador

Proceso:
Usuario introduce el código
Presiona botón Validar

Si es correcto:
Botón verde
Rol habilitado
Si es incorrecto:

Botón rojo
Registro bloqueado
Esto añade una capa adicional de seguridad.

# 🕒 Sistema de Asistencia
Registro de:
Entrada (Check-In)
Salida (Check-Out)

El sistema guarda:
Fecha
Hora de entrada
Hora de salida

Cada registro se almacena automáticamente.

# 👤 Panel de Usuario

Incluye:
Nombre completo
Estado (Activo / Inactivo)
Fotografía
Tipo de usuario
Historial de asistencia

Acciones:
Registrar Entrada
Registrar Salida
Ver historial
Cambiar configuración
Cerrar sesión

🛠️ Panel de Administrador

Funciones avanzadas:
Ver todos los usuarios
Filtrar por tipo
Generar códigos de validación
Activar / desactivar usuarios
Consultar historial
Configuración del sistema
=============================================================================

# 🔒 Seguridad del Sistema

Medidas implementadas:
Contraseñas con hash
Validación de campos
Control de acceso por roles
Protección contra múltiples registros
Validación administrativa

Reglas de contraseña:
Mínimo 8 caracteres
1 mayúscula
1 minúscula
1 número
1 carácter especial
=============================================================================

# 🔄 Flujo del Sistema
Administrador inicia sesión
Cambio obligatorio de credenciales
Generación de códigos
Registro de usuarios
Inicio de sesión
Acceso según rol
Registro de asistencia
=============================================================================

# ▶️ Instalación del Proyecto
Clonar repositorio
git clone https://github.com/your-repository/unitrack.git
Crear entorno virtual
python -m venv venv
Activar entorno
Windows:
venv\Scripts\activate
Instalar dependencias
pip install flask
pip install flask-sqlalchemy
pip install flask-login
pip install flask-migrate
pip install werkzeug
Ejecutar aplicación
python app.py
Abrir en navegador:
http://127.0.0.1:5000
=============================================================================
# 🚀 Mejoras Futuras
Migración a PostgreSQL
Sistema QR
Dashboard con estadísticas
Exportación PDF / Excel
API REST
Despliegue en cloud
Notificaciones automáticas
=============================================================================

# 💼 Posible Uso Comercial
Este sistema puede ser utilizado por:
Universidades
Institutos
Centros educativos
Empresas
=============================================================================

# 📜 Licencia
Proyecto desarrollado con fines académicos y educativos.
=============================================================================
# 📞 Contacto
# 📞 Numero Cellular: +526865090453
# 📞🟢 Whatsaap: +526865090453
# 👤 Autor:Peyman Miyandashti
# 🎓 Universidad:  Universidad Politécnica de Baja California
# 💻 Carrera: Ingeniería en Tecnologías de la Información e Innovación Digital
# 🆔 ID: 250161
# 📅 Year: 2026
# 🟦 Facebook: https://www.facebook.com/Peyman.Miyandashti
# 🌍 From IRAN (Mexico)
# 🌐Idiomas: English, Persian, Spanish, Turkish
===========================================================================
