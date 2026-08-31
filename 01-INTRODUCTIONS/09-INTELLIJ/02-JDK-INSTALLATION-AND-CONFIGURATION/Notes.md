# JDK Installation and Configuration Notes

## 1. The JVM ecosystem

### JVM

**JVM** means **Java Virtual Machine**.

The JVM executes compiled JVM bytecode. Java and Kotlin/JVM source code can both be compiled into bytecode that runs on a compatible JVM.

Simplified flow:

~~~text
Java or Kotlin source
        ↓
Compiler
        ↓
JVM bytecode
        ↓
Java Virtual Machine
        ↓
Program output
~~~

### JRE

**JRE** means **Java Runtime Environment**.

A runtime environment provides what is needed to run Java applications, but a standalone JRE does not provide the complete development toolchain required to compile new applications.

### JDK

**JDK** means **Java Development Kit**.

A JDK includes:

- a Java compiler;
- a Java runtime;
- standard libraries;
- diagnostic utilities;
- documentation tools; and
- other development commands.

For development, install a JDK rather than only a JRE.

### SDK

**SDK** means **Software Development Kit**.

IntelliJ IDEA uses the general term **SDK** for the development kit assigned to a project or module. For Java and Kotlin/JVM projects, the SDK is normally a JDK.

### Kotlin compiler

The Kotlin compiler translates Kotlin source into a target format such as JVM bytecode. A Kotlin/JVM project still uses a JDK for the JVM toolchain and runtime environment.

## 2. Source code and compiled output

Typical Java flow:

~~~text
Main.java → javac → Main.class → java → output
~~~

Typical Kotlin/JVM flow:

~~~text
Main.kt → Kotlin compiler → MainKt.class → JVM → output
~~~

The exact build process can be managed by IntelliJ IDEA, Gradle, or Maven.

## 3. Check whether Java already exists

Open a terminal and run:

~~~bash
java --version
javac --version
~~~

Possible interpretations:

| Result | Meaning |
|---|---|
| Both commands show compatible versions | A JDK is probably available on PATH |
| java works but javac fails | A runtime may exist without a complete JDK, or PATH is incomplete |
| Neither command works | No accessible Java installation is on PATH |
| Versions differ significantly | PATH may point to different Java installations |

These commands inspect the terminal environment. They do not prove that the current IntelliJ project uses the same JDK.

On some older distributions, the version command can use a single hyphen:

~~~bash
java -version
javac -version
~~~

## 4. Choose a JDK

Consider:

- the version required by the course or project;
- long-term-support policy;
- build-tool compatibility;
- framework compatibility;
- deployment environment;
- vendor support; and
- organizational requirements.

Do not automatically select the newest release when a project specifies another version.

Common distributions include:

- JetBrains Runtime for running the IDE itself;
- Oracle JDK;
- Eclipse Temurin;
- OpenJDK builds from operating-system vendors; and
- other standards-compliant distributions.

The runtime used to launch IntelliJ IDEA is not automatically the Project SDK.

## 5. Method A — Download a JDK through IntelliJ IDEA

During project creation:

1. Open IntelliJ IDEA.
2. Select **New Project**.
3. Choose Java or Kotlin.
4. Open the **JDK** list.
5. Select **Download JDK**.
6. Select a version compatible with the lesson or project.
7. Select an approved vendor.
8. Confirm the download location.
9. Start the download.
10. Wait for IntelliJ IDEA to finish registering it.

This is convenient for beginners because IntelliJ IDEA downloads and registers the JDK in one workflow.

## 6. Method B — Add an existing JDK from disk

Use this method when a JDK is already installed:

1. Open the JDK list in the new-project wizard or Project Structure.
2. Select **Add JDK from Disk**.
3. Browse to the JDK home directory.
4. Select the directory—not an individual executable.
5. Confirm that IntelliJ identifies the version.
6. Assign it to the project.

The exact directory varies by operating system and installation method. Do not publish a username or private directory path in repository evidence.

## 7. Configure Project SDK

For an existing project:

1. Open **File → Project Structure**.
2. Select **Project**.
3. Locate **SDK** or **Project SDK**.
4. Select the required JDK.
5. Review **Language level**.
6. Apply the changes.
7. Close Project Structure.

JetBrains also provides the shortcut:

~~~text
Ctrl + Alt + Shift + S
~~~

Shortcut behavior can vary by operating-system keymap.

## 8. Configure a module SDK

Some projects contain multiple modules.

In Project Structure:

1. select **Modules**;
2. select the module;
3. open **Dependencies**;
4. confirm the Module SDK; and
5. use the Project SDK unless the module intentionally requires another JDK.

A correctly configured project can still fail if one module overrides the SDK incorrectly.

## 9. Language level

The language level controls which Java language features the editor and compiler expect.

It should be compatible with:

- the selected JDK;
- source compatibility required by the project;
- build-tool configuration; and
- deployment target.

Selecting a newer JDK does not mean every project should use the newest language features.

## 10. Environment variables

### PATH

PATH tells the terminal where executable commands can be found.

If Java is installed but the terminal cannot find it, PATH may not include the JDK binary directory.

### JAVA_HOME

JAVA_HOME normally points to the JDK home directory. Build tools and scripts may use it to locate Java.

Rules:

- JAVA_HOME should point to the JDK home, not directly to its bin directory.
- PATH can include the JDK bin directory.
- Do not change system environment variables unless necessary.
- Record existing values before modifying them.
- Follow operating-system or organizational guidance.

IntelliJ IDEA can use a Project SDK even when terminal variables are different.

## 11. Verify inside IntelliJ IDEA

Check:

- the JDK appears under Platform Settings → SDKs;
- Project SDK selects that JDK;
- the language level is compatible;
- modules inherit the correct SDK; and
- External Libraries includes the selected JDK.

If the IDE is indexing the new SDK, wait until indexing completes.

## 12. Verify from the terminal

Run:

~~~bash
java --version
javac --version
~~~

For more context:

### Windows

~~~powershell
where.exe java
where.exe javac
~~~

### macOS or Linux

~~~bash
which java
which javac
~~~

These reveal which executable the terminal finds first. Avoid posting full private filesystem paths publicly.

## 13. Common problems

### No JDK specified

Cause: the project has no SDK.

Fix: select a JDK in Project Structure.

### Invalid SDK

Causes can include:

- the JDK directory was moved or deleted;
- the wrong folder was selected;
- the installation is incomplete; or
- the project references a JDK unavailable on this computer.

Fix: add a valid JDK home and reassign the SDK.

### java works but javac does not

Possible cause: only a runtime is accessible, or PATH points to the wrong installation.

Fix: install or expose a complete JDK and verify both commands.

### Terminal version and project version differ

Cause: terminal PATH and IntelliJ Project SDK are independent configurations.

Fix: decide which version the project requires, configure it intentionally, and align environment variables only when necessary.

### Unsupported class-file version

Cause: code was compiled with a newer JDK than the runtime used to execute it.

Fix: use a compatible runtime or compile for the required target.

### Language feature is unavailable

Cause: language level or source compatibility is older than the feature.

Fix: verify the project requirement before changing the level.

### JDK download fails

- check the internet connection;
- try an approved vendor;
- confirm proxy or firewall configuration;
- check available disk space; and
- use a manually approved installation when necessary.

## 14. Version-record template

Record:

| Field | Value |
|---|---|
| JDK vendor | |
| JDK version | |
| Installation method | IntelliJ download / system installer / package manager |
| Project SDK | |
| Language level | |
| java command result | |
| javac command result | |
| Verification date | |

Never record access tokens, license keys, or unnecessary private paths.

## 15. Completion boundary

This lesson ends when the JDK is installed and selected. Creating and running the first Kotlin project is the next separate lesson.

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026
