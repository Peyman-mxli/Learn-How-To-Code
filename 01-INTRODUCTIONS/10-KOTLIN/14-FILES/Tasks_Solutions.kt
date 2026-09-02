import java.io.File

/*
Files — Reference Solution

This example writes text to a file and reads it back.
*/

fun main() {
    val file = File("notes.txt")
    file.writeText("Hello Kotlin")
    println(file.readText())
}
