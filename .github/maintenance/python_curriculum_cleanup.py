#!/usr/bin/env python3
from pathlib import Path
import re

ROOT = Path(__file__).resolve().parents[2] / "01-INTRODUCTIONS" / "02-PYTHON"

def sanitize(text: str) -> str:
    out = []
    for line in text.splitlines():
        stripped = line.strip()
        top_level = line == line.lstrip()
        comment = False

        if top_level and stripped and not stripped.startswith("#"):
            if re.fullmatch(r"[\-=*_]{5,}", stripped):
                comment = True
            elif stripped.startswith(("📘", "📂", "👤", "🎓", "💻", "📍", "📅", "▶", "🏁")):
                comment = True
            elif stripped in {
                "Peyman Miyandashti",
                "Polytechnic University of Baja California",
                "Information Technology Engineering & Digital Innovation",
                "From IRAN (Mexico)",
                "Year: 2026",
            }:
                comment = True
            elif re.match(r"^-\s*[\"']", stripped):
                comment = True
            elif re.match(r"^Module\s+[—-]", stripped, re.I):
                comment = True

        out.append(("# " + line) if comment else line)

    return "\n".join(out) + "\n"

changed = 0
for path in ROOT.rglob("*.py"):
    original = path.read_text(encoding="utf-8")
    fixed = sanitize(original)
    if fixed != original:
        path.write_text(fixed, encoding="utf-8")
        changed += 1

print(f"Sanitized {changed} Python learning files.")
