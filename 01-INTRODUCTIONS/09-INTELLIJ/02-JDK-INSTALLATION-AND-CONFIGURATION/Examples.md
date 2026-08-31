# JDK Installation and Configuration Examples

## Example 1 — Interpret terminal results

Output:

~~~text
java 21.x
javac 21.x
~~~

Interpretation: both runtime and compiler are available, and their major versions align. The JDK still needs to be selected as the IntelliJ Project SDK.

## Example 2 — Detect a runtime-only or PATH problem

Result:

~~~text
java --version
# A version is displayed

javac --version
# Command not found
~~~

Possible explanations:

- only a runtime is installed;
- a JDK exists but its compiler is not on PATH; or
- Java commands resolve to different installations.

Next action: inspect the command locations and configure a complete JDK.

## Example 3 — Download through the project wizard

1. Select **New Project**.
2. Choose **Kotlin**.
3. Open the JDK list.
4. Select **Download JDK**.
5. Choose the version required by the project.
6. Select an approved vendor.
7. Download it.
8. Confirm that the selected JDK appears in the project wizard.

Expected result: IntelliJ registers and selects the downloaded JDK.

## Example 4 — Add an existing installation

A learner installed Eclipse Temurin using an approved installer.

1. Open **File → Project Structure**.
2. Open **SDKs**.
3. Select **Add JDK from Disk**.
4. Choose the Temurin JDK home.
5. Confirm the detected version.
6. Select it under **Project SDK**.

Expected result: External Libraries displays the JDK libraries.

## Example 5 — Explain two different versions

Terminal:

~~~text
java --version
# Major version 17
~~~

IntelliJ Project SDK:

~~~text
Major version 21
~~~

This is possible because the terminal uses PATH while IntelliJ uses the SDK recorded in project settings. It is not automatically an error, but it must match project requirements and build-tool configuration.

## Example 6 — Diagnose an invalid SDK

Symptom: the Project SDK name appears in red.

Investigation:

1. open Project Structure;
2. inspect the SDK home path;
3. determine whether the directory still exists;
4. add a valid JDK;
5. reassign Project SDK; and
6. allow indexing to finish.

## Example 7 — Check module inheritance

For a single-module beginner project:

- Project SDK: selected JDK
- Module SDK: Project SDK
- Language level: compatible project setting

This avoids unnecessary conflicting SDK configuration.

## Example 8 — Protect private evidence

Good evidence:

~~~text
Vendor: Eclipse Temurin
Major version: 21
Project SDK configured: Yes
java and javac verified: Yes
~~~

Avoid publishing:

- full user-directory paths;
- device identifiers;
- organization-only download URLs;
- credentials; or
- access tokens.

## Navigation

- [Lesson overview](./README.md)
- [Technical notes](./Notes.md)
- [Practice tasks](./Tasks.md)
