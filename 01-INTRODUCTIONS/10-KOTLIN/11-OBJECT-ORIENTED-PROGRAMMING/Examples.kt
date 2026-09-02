fun main() {
    class User(val name:String){ fun greet() = "Hello $name" }
    println(User("Peyman").greet())
}
