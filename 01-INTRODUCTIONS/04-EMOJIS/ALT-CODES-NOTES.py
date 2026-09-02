"""Notes and small demonstrations for Unicode and Windows ALT input."""

# ALT codes are a Windows input method for entering some characters.
# Exact numeric mappings can vary by code page, application, and keyboard
# configuration. Modern Python source code uses Unicode directly.

print("Box corner:", "╔")
print("Arrow:", "→")
print("Block:", "█")

# Best practices:
# - prefer Unicode characters directly in Python source code;
# - keep console output readable;
# - verify the target terminal/font can render the symbols;
# - do not rely on ALT-code input for cross-platform application logic.
