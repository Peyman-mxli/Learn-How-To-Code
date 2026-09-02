/*
Data Classes — Reference Solution

A valid solution should:
- compile successfully;
- demonstrate data classes, generated equals/hashCode/toString/copy;
- use clear names and Kotlin conventions;
- handle the task's requested edge case.

Compare your solution for correctness and readability rather than exact text.
*/

fun main() {
    data class User(val name:String,val age:Int)
    val a=User("Peyman",20)
    println(a.copy(age=21))
}
