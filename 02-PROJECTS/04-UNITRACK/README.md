# Project 04 — UniTrack

UniTrack is an educational Flask application for university attendance workflows. It demonstrates authentication, role-aware registration, SQLite persistence, image uploads, session handling, and check-in/check-out records.

## Current features

- user registration;
- password hashing with Werkzeug;
- login/logout sessions;
- student dashboard;
- check-in and check-out;
- SQLite persistence;
- optional administrator verification code;
- uploaded profile-image handling.

## Security improvements

Secrets are **not hard-coded**. Configure them through environment variables:

```text
UNITRACK_SECRET_KEY
UNITRACK_ADMIN_CODE
FLASK_DEBUG
```

Copy `.env.example` as a reference, but do not commit real secrets.

Passwords are stored as hashes rather than plaintext.

> This remains an educational prototype. Before production use it would still need CSRF protection, upload validation, authorization checks on every privileged route, migrations, logging, rate limiting, and a production database/deployment configuration.

## Install

```bash
python -m venv .venv
# Windows
.\.venv\Scripts\activate

pip install -r requirements.txt
```

Set the environment variables and run:

```bash
python app.py
```

Then open `http://127.0.0.1:5000`.

## Responsible repository practice

- do not commit `unitrack.db`;
- do not commit real admin codes or secret keys;
- do not commit personal user records or uploaded identity documents;
- do not commit virtual environments.

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026

