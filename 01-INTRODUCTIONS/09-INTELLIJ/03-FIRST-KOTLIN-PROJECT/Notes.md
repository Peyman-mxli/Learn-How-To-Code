# First Kotlin Project — Notes

## 1. Execution model

~~~text
Main.kt → Kotlin compiler → JVM bytecode → JVM → output
~~~

IntelliJ coordinates editing, compilation, run configuration, and output.

## 2. Create a project

1. Launch IntelliJ.
2. Return to Welcome with **File → Close Project** if needed.
3. Select **New Project**.
4. Choose **Kotlin**.
5. Name it HelloKotlin.
6. Choose a writable, non-sensitive location.
7. Select a build system.
8. Select the JDK configured previously.
9. Optionally initialize Git.
10. Select **Create**.
11. Wait for indexing and synchronization.

If Kotlin is unavailable, confirm Kotlin support is enabled and use a supported stable IntelliJ release.

## 3. Build-system choice

### IntelliJ

Simple for a first program, with less configuration, but less representative of many portable builds.

### Gradle

Common for modern Kotlin/JVM projects, dependencies, tests, plugins, and repeatable builds. Kotlin DSL commonly uses files ending in .gradle.kts.

### Maven

Useful for Maven-standardized JVM projects and XML configuration.

Follow explicit project requirements. IntelliJ is suitable for the simplest first run; Gradle with Kotlin DSL is a strong professional learning choice.

## 4. JDK selection

Select a registered compatible JDK. Avoid **None**. Use **Download JDK** only when the required version is missing.

The runtime launching IntelliJ is not automatically the Project SDK.

## 5. Git initialization

Initialize Git only when the repository location is understood. Never commit credentials, tokens, keys, secrets, caches, or generated build output.

## 6. Typical Gradle structure

~~~text
HelloKotlin/
├── src/
│   └── main/
│       └── kotlin/
│           └── Main.kt
├── build.gradle.kts
├── settings.gradle.kts
├── gradle/
├── .idea/
└── build/
~~~

Exact structure varies.

- Source contains developer-maintained code.
- Main.kt is the Kotlin entry source.
- .idea contains IntelliJ metadata.
- build contains generated output.
- External Libraries is an IDE view of JDK and dependencies.

## 7. Create Main.kt

Under the Kotlin source root, select **New → Kotlin Class/File**, choose **File**, name it Main, and enter:

~~~kotlin
fun main() {
    println("Hello from IntelliJ IDEA!")
}
~~~

Do not create source inside build.

## 8. Code explanation

- **fun** declares a function.
- **main** is the entry point.
- Parentheses hold parameters.
- Braces contain the body.
- **println** prints with a line break.
- Quoted text is a String.

## 9. Run

Use the Run icon beside main, right-click and choose Run, select the toolbar configuration, or use the current keymap shortcut.

Common Windows keymap:

~~~text
Shift + F10
~~~

Run can show the command, output, errors, and exit information.

~~~text
Hello from IntelliJ IDEA!

Process finished with exit code 0
~~~

## 10. Modify and rerun

~~~kotlin
fun main() {
    val learner = "Peyman"
    println("Hello, $learner!")
    println("My first Kotlin project is running.")
}
~~~

## 11. Run configuration

It normally identifies the entry point, module or classpath, JDK, working directory, arguments, and environment variables. Do not store secrets in shared configurations.

## 12. Troubleshooting

### No Run icon

Check syntax, source-root location, Kotlin support, indexing, Project SDK, and build synchronization.

### Project SDK not defined

Select a valid JDK in Project Structure.

### Gradle sync fails

Check connection, full error, JDK compatibility, proxy, and configuration. Avoid random version changes.

### Unresolved println

Possible causes include invalid setup, failed indexing, missing Kotlin support, or invalid SDK.

### Old output remains

Confirm the file is saved, correct Main.kt was edited, correct configuration ran, compilation succeeded, and the latest output tab is visible.

### Main.kt is inside build

Recreate it under the proper source root. Generated output is not permanent source.

## 13. Verification record

| Field | Value |
|---|---|
| Project name | |
| Build system | |
| JDK vendor and version | |
| Main file | |
| Expected output | |
| Exit code | |
| Verification date | |

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026
