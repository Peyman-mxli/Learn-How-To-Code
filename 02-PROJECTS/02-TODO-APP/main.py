"""In-memory command-line todo application."""

from __future__ import annotations


def add_task(tasks: list[dict[str, object]], title: str) -> None:
    title = title.strip()
    if not title:
        raise ValueError("Task title cannot be empty.")
    tasks.append({"title": title, "completed": False})


def complete_task(tasks: list[dict[str, object]], index: int) -> None:
    if index < 0 or index >= len(tasks):
        raise IndexError("Task number is out of range.")
    tasks[index]["completed"] = True


def delete_task(tasks: list[dict[str, object]], index: int) -> None:
    if index < 0 or index >= len(tasks):
        raise IndexError("Task number is out of range.")
    tasks.pop(index)


def print_tasks(tasks: list[dict[str, object]]) -> None:
    if not tasks:
        print("No tasks available.")
        return

    for number, task in enumerate(tasks, start=1):
        status = "✓" if task["completed"] else " "
        print(f"{number}. [{status}] {task['title']}")


def read_task_index(tasks: list[dict[str, object]]) -> int:
    print_tasks(tasks)
    raw = input("Task number: ").strip()
    try:
        return int(raw) - 1
    except ValueError as exc:
        raise ValueError("Task number must be an integer.") from exc


def main() -> None:
    tasks: list[dict[str, object]] = []

    while True:
        print("\n=== TODO APP ===")
        print("1. Add task")
        print("2. View tasks")
        print("3. Complete task")
        print("4. Delete task")
        print("5. Exit")

        choice = input("Select option: ").strip()

        try:
            if choice == "1":
                add_task(tasks, input("Task title: "))
                print("Task added.")
            elif choice == "2":
                print_tasks(tasks)
            elif choice == "3":
                complete_task(tasks, read_task_index(tasks))
                print("Task completed.")
            elif choice == "4":
                delete_task(tasks, read_task_index(tasks))
                print("Task deleted.")
            elif choice == "5":
                print("Goodbye.")
                return
            else:
                print("Invalid choice.")
        except (ValueError, IndexError) as exc:
            print(f"Error: {exc}")


if __name__ == "__main__":
    main()
