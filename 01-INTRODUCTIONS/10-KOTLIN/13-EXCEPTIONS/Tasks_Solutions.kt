/*
Exceptions — Reference Solution

A valid solution should:
- compile successfully;
- demonstrate try/catch/finally, throw, validation;
- use clear names and Kotlin conventions;
- handle the task's requested edge case.

Compare your solution for correctness and readability rather than exact text.
*/

fun main() {
    try { println("10".toInt()) } catch(e:NumberFormatException){ println("Invalid") }
}
