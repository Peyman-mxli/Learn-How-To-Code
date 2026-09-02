"""Unicode console-output examples.

Windows ALT codes are an input technique; Python strings themselves use
Unicode. These examples therefore store the characters directly.
"""

def print_symbol_reference() -> None:
    rows = [
        ("─", "horizontal line"),
        ("│", "vertical line"),
        ("╔", "top-left corner"),
        ("╗", "top-right corner"),
        ("╚", "bottom-left corner"),
        ("╝", "bottom-right corner"),
        ("→", "right arrow"),
        ("←", "left arrow"),
        ("±", "plus/minus"),
        ("€", "euro"),
        ("ñ", "lowercase n with tilde"),
        ("©", "copyright"),
    ]

    print("Symbol reference")
    print("-" * 36)
    for symbol, description in rows:
        print(f"{symbol:<3} {description}")


def print_box(message: str) -> None:
    width = len(message) + 2
    print("╔" + "═" * width + "╗")
    print(f"║ {message} ║")
    print("╚" + "═" * width + "╝")


def main() -> None:
    print_symbol_reference()
    print()
    print_box("Unicode works in Python")
    print("Progress:", "░▒▓█")
    print("Spanish:", "ñ Ñ á é í ó ú")


if __name__ == "__main__":
    main()
