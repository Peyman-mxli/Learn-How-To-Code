/*
Conditional Statements — Reference Solution

A valid solution should:
- compile successfully;
- demonstrate if/else as statements and expressions;
- use clear names and Kotlin conventions;
- handle the task's requested edge case.

Compare your solution for correctness and readability rather than exact text.
*/

fun main() {
    val age = 20
    val access = if (age >= 18) "allowed" else "denied"
    println(access)
}
