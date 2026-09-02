/*
Object-Oriented Programming — Reference Solution

A valid solution should:
- compile successfully;
- demonstrate classes, properties, methods, constructors, inheritance basics;
- use clear names and Kotlin conventions;
- handle the task's requested edge case.

Compare your solution for correctness and readability rather than exact text.
*/

fun main() {
    class User(val name:String){ fun greet() = "Hello $name" }
    println(User("Peyman").greet())
}
