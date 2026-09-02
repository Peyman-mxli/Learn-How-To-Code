#!/usr/bin/env python3
from pathlib import Path
import re

ROOT = Path(__file__).resolve().parents[2] / "01-INTRODUCTIONS" / "02-PYTHON"

AUTHOR_LINES = {
    "Peyman Miyandashti",
    "Polytechnic University of Baja California",
    "Information Technology Engineering & Digital Innovation",
    "From IRAN (Mexico)",
    "Year: 2026",
}

EMOJI_PREFIXES = (
    "📘", "📂", "📁", "👤", "🎓", "💻", "📍", "📅", "▶", "🏁",
    "⚠", "🔹", "🔸", "🟢", "🟡", "🟠", "🔴", "🟣", "🧠",
    "1️⃣", "2️⃣", "3️⃣", "4️⃣", "5️⃣", "6️⃣", "7️⃣", "8️⃣", "9️⃣",
)


def basic_sanitize(text: str) -> str:
    out = []
    for line in text.splitlines():
        stripped = line.strip()
        top_level = line == line.lstrip()
        comment = False

        if top_level and stripped and not stripped.startswith("#"):
            if re.fullmatch(r"[\-=*_]{5,}", stripped):
                comment = True
            elif stripped.startswith(EMOJI_PREFIXES):
                comment = True
            elif stripped in AUTHOR_LINES:
                comment = True
            elif stripped.startswith("- "):
                comment = True
            elif re.match(r"^(Module|Rank|Example|Task|Step|Level)\s+\d*\s*[—-]", stripped, re.I):
                comment = True

        out.append(("# " + line) if comment else line)

    return "\n".join(out) + "\n"


def comment_entire_file(text: str) -> str:
    return "\n".join(
        line if line.startswith("#") else "# " + line
        for line in text.splitlines()
    ) + "\n"


def looks_like_prose(line: str) -> bool:
    stripped = line.strip()
    if not stripped or stripped.startswith("#"):
        return False
    if stripped.startswith(EMOJI_PREFIXES) or stripped in AUTHOR_LINES:
        return True
    if stripped.startswith("- "):
        return True
    if "→" in stripped or "—" in stripped:
        return True
    if re.match(r"^(Module|Rank|Example|Task|Step|Level)\b", stripped, re.I):
        return True
    if re.fullmatch(r"[\-=*_]{5,}", stripped):
        return True
    return False


def repair_non_notes(text: str, filename: str) -> str:
    lines = text.splitlines()

    for _ in range(100):
        source = "\n".join(lines) + "\n"
        try:
            compile(source, filename, "exec")
            return source
        except SyntaxError as exc:
            if not exc.lineno or exc.lineno < 1 or exc.lineno > len(lines):
                return source

            index = exc.lineno - 1
            line = lines[index]

            if looks_like_prose(line):
                lines[index] = "# " + line
                continue

            # A common legacy footer/header line can be plain text without
            # symbols. Comment it only when it clearly contains multiple
            # words and no Python expression punctuation.
            stripped = line.strip()
            if (
                line == line.lstrip()
                and len(stripped.split()) >= 2
                and not any(token in stripped for token in ("=", "(", ")", "[", "]", "{", "}", ":"))
                and not stripped.startswith(("def ", "class ", "import ", "from ", "return ", "raise ", "assert "))
            ):
                lines[index] = "# " + line
                continue

            return source

    return "\n".join(lines) + "\n"


changed = 0
for path in ROOT.rglob("*.py"):
    original = path.read_text(encoding="utf-8")
    fixed = basic_sanitize(original)

    try:
        compile(fixed, str(path), "exec")
    except SyntaxError:
        if "NOTES" in path.name.upper():
            fixed = comment_entire_file(fixed)
        else:
            fixed = repair_non_notes(fixed, str(path))

    if fixed != original:
        path.write_text(fixed, encoding="utf-8")
        changed += 1

print(f"Sanitized {changed} Python learning files.")
