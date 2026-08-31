# JDK Installation and Configuration Tasks

## Rank 1 — Concepts

### Task 1

Define:

- JVM
- JRE
- JDK
- SDK
- Kotlin compiler

### Task 2

Explain why a standalone JRE is insufficient for compiling a new Java program.

### Task 3

Describe the source-to-execution flow for Kotlin/JVM.

## Rank 2 — Environment inspection

### Task 4

Run:

~~~bash
java --version
javac --version
~~~

Record only the vendor and version information needed for the lesson.

### Task 5

Determine which Java and compiler executables the terminal finds.

Windows:

~~~powershell
where.exe java
where.exe javac
~~~

macOS or Linux:

~~~bash
which java
which javac
~~~

Do not commit private absolute paths.

### Task 6

Classify the result:

- full JDK available;
- runtime only;
- Java not accessible;
- mismatched versions; or
- uncertain and requires investigation.

## Rank 3 — Installation

### Task 7

Choose one approved method:

- Download JDK from IntelliJ IDEA
- Add JDK from Disk
- Use an organization-approved installer or package manager

Explain why it is appropriate.

### Task 8

Install or register the JDK and record:

| Field | Your result |
|---|---|
| Vendor | |
| Version | |
| Installation method | |
| Verification date | |

### Task 9

Open **File → Project Structure → SDKs** and confirm the JDK appears.

## Rank 4 — Project configuration

### Task 10

Assign the JDK as the Project SDK.

### Task 11

Check the project language level and explain why it must be compatible with the project and JDK.

### Task 12

Check the Module SDK. Use Project SDK unless there is a documented reason not to.

### Task 13

Confirm that External Libraries shows the configured JDK.

## Rank 5 — Troubleshooting

### Task 14

Explain how terminal Java can differ from the IntelliJ Project SDK.

### Task 15

Provide a recovery plan for **Invalid SDK**.

### Task 16

Explain the likely cause of **Unsupported class-file version**.

### Task 17

Explain why JAVA_HOME should point to the JDK home rather than directly to its bin directory.

## Final verification

- [ ] java reports a version.
- [ ] javac reports a compatible version.
- [ ] The JDK appears in IntelliJ SDKs.
- [ ] Project SDK is selected.
- [ ] Module SDK is correct.
- [ ] Language level is intentional.
- [ ] External Libraries shows the JDK.
- [ ] No sensitive paths or credentials were published.

## Navigation

- [Lesson overview](./README.md)
- [Examples](./Examples.md)
- [Reference solutions](./Tasks_Solutions.md)
