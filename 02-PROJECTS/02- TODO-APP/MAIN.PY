"""
====================================================
📘 TODO APPLICATION
📁 MAIN PROGRAM
====================================================
Simple CLI-based task manager.
"""
# ====================================================
# DATA STORAGE
# ====================================================

tasks = []

# ====================================================
# FUNCTIONS
# ====================================================

def add_task():
    title = input("Enter task: ")
    tasks.append({"title": title, "completed": False})
    print("Task added.")

def view_tasks():
    if not tasks:
        print("No tasks available.")
        return

    for i, task in enumerate(tasks):
        status = "✔" if task["completed"] else "✘"
        print(f"{i + 1}. {task['title']} [{status}]")

def complete_task():
    view_tasks()
    try:
        index = int(input("Select task number: ")) - 1
        tasks[index]["completed"] = True
        print("Task completed.")
    except:
        print("Invalid selection.")

def delete_task():
    view_tasks()
    try:
        index = int(input("Select task number: ")) - 1
        tasks.pop(index)
        print("Task deleted.")
    except:
        print("Invalid selection.")

# ====================================================
# MAIN LOOP
# ====================================================

while True:
    print("\n==============================")
    print("        TODO APP")
    print("==============================")
    print("1. Add Task")
    print("2. View Tasks")
    print("3. Complete Task")
    print("4. Delete Task")
    print("5. Exit")

    choice = input("Select option: ")

    if choice == "1":
        add_task()
    elif choice == "2":
        view_tasks()
    elif choice == "3":
        complete_task()
    elif choice == "4":
        delete_task()
    elif choice == "5":
        print("Exiting...")
        break
    else:
        print("Invalid choice.")

# ====================================================
# END OF PROGRAM
# ====================================================
# 👤 Author
# ====================================================
Peyman Miyandashti
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
# ====================================================
