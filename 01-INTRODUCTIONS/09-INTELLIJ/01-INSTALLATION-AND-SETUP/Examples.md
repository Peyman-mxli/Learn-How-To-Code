# Installation and Setup Examples

These guided scenarios show how to make safe installation decisions and verify the result.

## Example 1 — Check compatibility before downloading

Suppose a Windows computer has:

- Windows 11;
- a four-core x86_64 processor;
- 16 GB RAM;
- 35 GB free SSD space; and
- a 1920 × 1080 display.

| Requirement | Computer | Result |
|---|---:|---|
| Supported architecture | x86_64 | Pass |
| Four CPU cores | Four | Pass |
| 8 GB total RAM | 16 GB | Pass |
| 10 GB disk space | 35 GB | Pass |
| 1280 × 720 display | 1920 × 1080 | Pass |

Conclusion: the computer is suitable for installation.

## Example 2 — Choose an installation method

A learner who expects to use several JetBrains products and wants centralized updates can select Toolbox.

A school laboratory with a manually approved release can use the standalone installer supplied under its administrator's policy.

## Example 3 — Verify the installer

Before opening it:

1. confirm that the download came from jetbrains.com;
2. confirm the correct operating system;
3. confirm ARM64 or x86_64 when a choice exists;
4. reject unexpected mirrors; and
5. scan the file according to applicable policy.

## Example 4 — Complete first launch

For a first installation, select **Do not import settings**, review privacy and license choices, choose a readable theme, avoid optional plugins, and continue to the Welcome screen.

## Example 5 — Record the version

Open **Help → About** and record:

| Field | Example |
|---|---|
| IntelliJ IDEA version | Value displayed by the IDE |
| Build number | Value displayed by the IDE |
| Operating system | Windows, macOS, or Linux distribution |
| Installation method | Toolbox or standalone |
| Date verified | YYYY-MM-DD |

Never invent the version number.

## Example 6 — Evaluate a plugin

Before installing an optional plugin, check its publisher, compatibility, maintenance, purpose, and whether built-in functionality is sufficient. Postpone installation when there is no clear need.

## Example 7 — Diagnose slow startup

High CPU usage and an indexing progress indicator normally mean first-time indexing is active. Wait for it to finish, keep adequate disk space available, and investigate only if the IDE stays unresponsive for an extended period.

## Example 8 — Return to Welcome

If a project opens automatically, save changes and select **File → Close Project**. Confirm that **New Project**, **Open**, and **Get from VCS** appear.

## Navigation

- [Lesson overview](./README.md)
- [Installation notes](./Notes.md)
- [Practice tasks](./Tasks.md)
