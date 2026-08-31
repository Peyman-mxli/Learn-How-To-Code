# JDK Installation and Configuration

This lesson prepares IntelliJ IDEA to build and run Java Virtual Machine applications by installing a Java Development Kit and assigning it as the project SDK.

## Why this lesson matters

Installing IntelliJ IDEA does not install every tool required to compile JVM programs. A project needs a valid JDK that provides the compiler, runtime, standard libraries, and development utilities.

Without a configured JDK, IntelliJ IDEA can show errors such as:

- **Project SDK is not defined**
- **No JDK specified**
- **Cannot resolve symbol**
- **Run configuration error**
- **Java compiler is not available**

## Learning objectives

After completing this lesson, learners will be able to:

- distinguish the JVM, JRE, JDK, SDK, and Kotlin compiler;
- explain why JVM development needs a JDK;
- inspect an existing Java installation;
- download a JDK safely through IntelliJ IDEA;
- add an existing JDK from disk;
- assign a Project SDK;
- verify the selected SDK and language level;
- run Java and compiler version commands; and
- diagnose common JDK configuration problems.

## Lesson materials

| File | Purpose |
|---|---|
| [Notes.md](./Notes.md) | Concepts, installation methods, IntelliJ configuration, and troubleshooting |
| [Examples.md](./Examples.md) | Guided JDK detection and configuration scenarios |
| [Tasks.md](./Tasks.md) | Independent configuration and verification activities |
| [Tasks_Solutions.md](./Tasks_Solutions.md) | Expected results and reference answers |

## Official references

- [JetBrains SDK documentation](https://www.jetbrains.com/help/idea/sdk.html)
- [JetBrains project structure settings](https://www.jetbrains.com/help/idea/project-settings-and-structure.html)
- [JetBrains new-project wizard](https://www.jetbrains.com/help/idea/new-project-wizard.html)
- [Oracle Java downloads](https://www.oracle.com/java/technologies/downloads/)
- [Eclipse Temurin downloads](https://adoptium.net/temurin/releases/)

Use a JDK source approved by the project, school, employer, or organization. Do not download Java installers from unverified mirrors.

## Completion criteria

- [ ] I can explain JVM, JRE, and JDK.
- [ ] A supported JDK is installed.
- [ ] IntelliJ IDEA recognizes the JDK.
- [ ] A Project SDK is selected.
- [ ] The project language level is compatible.
- [ ] The terminal reports Java and compiler versions.
- [ ] I can distinguish a system Java installation from an IntelliJ project SDK.
- [ ] I recorded the vendor, version, and installation method.
- [ ] I did not publish private filesystem or account information.

## Recommended workflow

1. Read Notes.md.
2. Check the existing environment.
3. Follow the appropriate JDK installation method.
4. Configure the Project SDK.
5. Complete Examples.md.
6. Perform the tasks independently.
7. Compare with Tasks_Solutions.md.

## Navigation

- [Previous: IntelliJ installation](../01-INSTALLATION-AND-SETUP/)
- [IntelliJ IDEA module](../)
- [Programming foundations](../../)

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026
