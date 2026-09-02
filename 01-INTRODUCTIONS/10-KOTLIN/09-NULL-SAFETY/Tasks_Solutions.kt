/*
Null Safety — Reference Solution

A valid solution should:
- compile successfully;
- demonstrate nullable types, safe calls, Elvis operator, non-null assertions;
- use clear names and Kotlin conventions;
- handle the task's requested edge case.

Compare your solution for correctness and readability rather than exact text.
*/

fun main() {
    val name: String? = null
    println(name?.length ?: 0)
}
