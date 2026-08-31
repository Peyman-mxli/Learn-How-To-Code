# First Kotlin Project — Reference Solutions

## Task 1

The JDK supplies the JVM toolchain and runtime. The Kotlin compiler produces JVM bytecode. The JVM executes it. A build system coordinates compilation, dependencies, tests, and packaging.

## Task 2

Gradle supports professional dependency and test workflows but adds configuration. IntelliJ is simpler initially but less representative of portable builds.

## Tasks 3–5

HelloKotlin should open with a valid JDK. The learner should identify source, configuration, metadata, generated output, and libraries without exposing private paths.

## Task 6

~~~kotlin
fun main() {
    println("Hello from IntelliJ IDEA!")
}
~~~

Expected output is the same message and normal exit code 0.

## Task 7

Expected:

~~~text
My Kotlin environment is ready.
~~~

## Task 8

~~~kotlin
fun main() {
    val preferredName = "Peyman"
    println("Hello, $preferredName!")
}
~~~

## Task 9

fun declares a function; main is the entry; parentheses contain parameters; braces contain the body; println prints; quoted text is a String.

## Task 10

Build is generated and can be deleted during cleaning or rebuilding.

## Task 11

Source is maintained code. External Libraries represents SDK and dependencies. Generated output is produced by the build.

## Task 12

The configuration should use the intended entry, module, compatible JDK, and working directory.

## Task 13

Check syntax, source-root location, Kotlin support, Project SDK, indexing, and synchronization.

## Task 14

Open Project Structure, select a valid JDK, assign Project and Module SDKs, and wait for indexing.

## Task 15

Check saved state, edited file, selected configuration, compilation result, rerun action, and latest Run tab.

## Task 16

Observe the error, correct syntax, rerun, and verify exit code 0.

## Navigation

- [Overview](./README.md)
- [Tasks](./Tasks.md)
- [Previous lesson](../02-JDK-INSTALLATION-AND-CONFIGURATION/)
