# First Kotlin Project — Examples

## Example 1 — Minimal

~~~kotlin
fun main() {
    println("Hello from IntelliJ IDEA!")
}
~~~

Expected:

~~~text
Hello from IntelliJ IDEA!
~~~

## Example 2 — Multiple lines

~~~kotlin
fun main() {
    println("Kotlin is configured.")
    println("The project is running.")
}
~~~

## Example 3 — Variable and string template

~~~kotlin
fun main() {
    val learner = "Peyman"
    val module = "IntelliJ IDEA"
    println("Learner: $learner")
    println("Module: $module")
}
~~~

## Example 4 — Calculation

~~~kotlin
fun main() {
    val firstNumber = 12
    val secondNumber = 8
    val total = firstNumber + secondNumber
    println("$firstNumber + $secondNumber = $total")
}
~~~

Expected:

~~~text
12 + 8 = 20
~~~

## Example 5 — Arguments

~~~kotlin
fun main(args: Array<String>) {
    println("Number of arguments: ${args.size}")
    for (argument in args) {
        println(argument)
    }
}
~~~

Do not place secrets in arguments.

## Example 6 — Syntax correction

Incorrect:

~~~kotlin
fun main() {
    println("Missing parenthesis"
}
~~~

Correct:

~~~kotlin
fun main() {
    println("Parenthesis corrected")
}
~~~

## Example 7 — Correct location

Incorrect:

~~~text
HelloKotlin/build/Main.kt
~~~

Conventional Gradle source:

~~~text
HelloKotlin/src/main/kotlin/Main.kt
~~~

## Example 8 — Rerun

Change output from Version 1 to Version 2 and rerun. If old output remains, inspect the file and configuration.

## Navigation

- [Lesson overview](./README.md)
- [Notes](./Notes.md)
- [Tasks](./Tasks.md)
