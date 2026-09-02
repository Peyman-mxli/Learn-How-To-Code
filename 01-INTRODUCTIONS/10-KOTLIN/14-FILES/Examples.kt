import java.io.File

fun main() {
    val file = File("notes.txt")
    file.writeText("Hello Kotlin")
    println(file.readText())
}
