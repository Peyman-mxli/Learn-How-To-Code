#!/usr/bin/env python3
"""Quality checks for the HTML curriculum.

This intentionally checks repository conventions and high-value structural
requirements without pretending to replace the WHATWG HTML validator.
"""

from html.parser import HTMLParser
from pathlib import Path
import re
import sys

ROOT = Path("01-INTRODUCTIONS/11-HTML")
REQUIRED_FILES = {
    "README.md",
    "Notes.md",
    "Examples.html",
    "Tasks.md",
    "Tasks_Solutions.html",
}


class Inspector(HTMLParser):
    def __init__(self):
        super().__init__(convert_charrefs=True)
        self.has_lang = False
        self.has_charset = False
        self.has_viewport = False
        self.in_title = False
        self.title = []
        self.ids = []
        self.images_without_alt = []

    def handle_starttag(self, tag, attrs):
        values = dict(attrs)

        if tag == "html" and values.get("lang", "").strip():
            self.has_lang = True

        if tag == "meta":
            if values.get("charset", "").lower() == "utf-8":
                self.has_charset = True
            if values.get("name", "").lower() == "viewport" and values.get("content"):
                self.has_viewport = True

        if tag == "title":
            self.in_title = True

        if values.get("id"):
            self.ids.append(values["id"])

        if tag == "img" and "alt" not in values:
            self.images_without_alt.append(self.getpos()[0])

    def handle_endtag(self, tag):
        if tag == "title":
            self.in_title = False

    def handle_data(self, data):
        if self.in_title:
            self.title.append(data)


problems = []

if not ROOT.exists():
    problems.append(f"Missing HTML curriculum root: {ROOT}")
else:
    modules = sorted(path for path in ROOT.iterdir() if path.is_dir())
    expected_prefixes = [f"{number:02d}" for number in range(21)]
    actual_prefixes = [path.name[:2] for path in modules]

    if actual_prefixes != expected_prefixes:
        problems.append(
            f"Expected modules 00-20 exactly once. Found: {actual_prefixes}"
        )

    for module in modules:
        existing = {path.name for path in module.iterdir() if path.is_file()}
        missing = sorted(REQUIRED_FILES - existing)
        if missing:
            problems.append(f"{module}: missing files {missing}")

    for path in ROOT.rglob("*.html"):
        text = path.read_text(encoding="utf-8")

        if not re.match(r"\s*<!doctype\s+html>", text, flags=re.I):
            problems.append(f"{path}: missing HTML5 doctype")

        inspector = Inspector()
        try:
            inspector.feed(text)
            inspector.close()
        except Exception as exc:
            problems.append(f"{path}: parser error: {exc}")
            continue

        if not inspector.has_lang:
            problems.append(f"{path}: html element needs a non-empty lang")
        if not inspector.has_charset:
            problems.append(f"{path}: missing UTF-8 charset metadata")
        if not inspector.has_viewport:
            problems.append(f"{path}: missing viewport metadata")
        if not "".join(inspector.title).strip():
            problems.append(f"{path}: title must not be empty")

        duplicates = sorted({
            item for item in inspector.ids
            if inspector.ids.count(item) > 1
        })
        if duplicates:
            problems.append(f"{path}: duplicate IDs {duplicates}")

        if inspector.images_without_alt:
            problems.append(
                f"{path}: images missing alt at lines "
                f"{inspector.images_without_alt}"
            )

if problems:
    print("HTML curriculum checks failed:")
    for problem in problems:
        print(f"- {problem}")
    sys.exit(1)

module_count = len([p for p in ROOT.iterdir() if p.is_dir()])
html_count = len(list(ROOT.rglob("*.html")))
print(
    f"HTML curriculum checks passed: "
    f"{module_count} modules, {html_count} HTML documents."
)
