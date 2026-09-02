/*
when Expression — Reference Solution

A valid solution should:
- compile successfully;
- demonstrate multi-branch decisions, subject and subjectless when;
- use clear names and Kotlin conventions;
- handle the task's requested edge case.

Compare your solution for correctness and readability rather than exact text.
*/

fun main() {
    val day = 2
    println(when(day){1->"Mon";2->"Tue";else->"Other"})
}
