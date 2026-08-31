# JDK Installation and Configuration — Reference Solutions

Exact vendors, versions, paths, and screenshots vary.

## Task 1

- **JVM:** virtual machine that executes JVM bytecode.
- **JRE:** runtime components needed to execute Java applications.
- **JDK:** development kit containing runtime, compiler, libraries, and tools.
- **SDK:** general development kit assigned to an IntelliJ project or module.
- **Kotlin compiler:** compiler that translates Kotlin source into a target such as JVM bytecode.

## Task 2

A standalone JRE does not include the complete compiler and development utilities needed to build new Java applications. Development requires a JDK.

## Task 3

~~~text
Kotlin source → Kotlin compiler → JVM bytecode → JVM → output
~~~

## Tasks 4–6

A complete JDK normally provides both java and javac. If only java works, a runtime-only or PATH problem may exist. If neither works, Java is not accessible from the terminal. Major-version differences require investigation.

## Task 7

Any method is valid when the source is approved and the selected version matches project requirements. IntelliJ's Download JDK option is convenient for beginners; Add JDK from Disk is appropriate when an installation already exists.

## Task 8

A complete record includes vendor, version, method, and date. It excludes credentials and unnecessary private paths.

## Task 9

Expected result: the JDK is listed under Platform Settings → SDKs and its home is valid.

## Task 10

Expected result: Project SDK identifies the required JDK rather than **None**.

## Task 11

Language level controls permitted Java language features and must remain compatible with the build and deployment target.

## Task 12

For a basic single-module project, Module SDK should inherit Project SDK unless a specific design requires another JDK.

## Task 13

Expected result: External Libraries contains the selected JDK's libraries.

## Task 14

The terminal resolves Java through PATH. IntelliJ resolves the project toolchain through Project SDK and possibly the build tool. These settings can legitimately point to different installations.

## Task 15

1. Open Project Structure.
2. Inspect the invalid SDK.
3. Confirm whether its directory exists.
4. add or download a valid JDK;
5. select it as Project SDK;
6. confirm Module SDK; and
7. wait for indexing.

## Task 16

The application was compiled for a newer class-file version than the runtime supports. Use a compatible runtime or compile for the required target.

## Task 17

JAVA_HOME identifies the JDK installation root. Tools derive internal locations, including bin, from that home. PATH can separately include the bin directory.

## Final outcome

The JDK is ready when both development commands work as intended, IntelliJ recognizes the SDK, and the project and module select a compatible configuration.

## Navigation

- [Lesson overview](./README.md)
- [Practice tasks](./Tasks.md)
- [Previous lesson](../01-INSTALLATION-AND-SETUP/)
