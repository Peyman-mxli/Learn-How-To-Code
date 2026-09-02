/*
Files — Reference Solution

A valid solution should:
- compile successfully;
- demonstrate java.io.File, reading/writing text, paths and exceptions;
- use clear names and Kotlin conventions;
- handle the task's requested edge case.

Compare your solution for correctness and readability rather than exact text.
*/

fun main() {
    import java.io.File
    File("notes.txt").writeText("Hello Kotlin")
    println(File("notes.txt").readText())
}
