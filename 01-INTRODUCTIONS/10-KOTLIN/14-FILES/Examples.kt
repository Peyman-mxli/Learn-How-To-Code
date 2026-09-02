fun main() {
    import java.io.File
    File("notes.txt").writeText("Hello Kotlin")
    println(File("notes.txt").readText())
}
