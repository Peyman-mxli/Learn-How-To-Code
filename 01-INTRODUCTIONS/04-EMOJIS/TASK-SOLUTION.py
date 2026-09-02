"""Reference solutions for TASKS.py."""


def print_separator() -> None:
    print("─" * 30)


def print_small_box(message: str) -> None:
    width = len(message) + 2
    print("╔" + "═" * width + "╗")
    print(f"║ {message} ║")
    print("╚" + "═" * width + "╝")


def print_menu(options: list[str]) -> None:
    for option in options:
        print("➤", option)


def print_progress(level: int) -> None:
    level = max(0, min(level, 4))
    shades = "░▒▓█"
    print(shades[:level])


if __name__ == "__main__":
    print_separator()
    print_small_box("Hello Unicode")
    print_menu(["Start", "Settings", "Exit"])
    print_progress(4)
