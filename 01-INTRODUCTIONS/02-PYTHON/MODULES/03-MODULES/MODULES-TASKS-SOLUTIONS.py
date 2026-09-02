"""Reference solutions for the Python Modules lesson.

Run each section only after attempting the corresponding task.
"""

import datetime
import math
import random

print("Value of PI:", math.pi)
print("Random number (1-5):", random.randint(1, 5))
print("Current year:", datetime.datetime.now().year)

print("Square root of 81:", math.sqrt(81))
print("3 raised to power 4:", math.pow(3, 4))

roles = ["Admin", "User", "Guest"]
print("Random role:", random.choice(roles))

now = datetime.datetime.now()
print("Current date:", now.date())
print("Current time:", now.time())

# Later tasks in the lesson demonstrate custom modules and third-party
# packages. Run those examples only after creating the referenced modules
# and installing their dependencies in a virtual environment.
