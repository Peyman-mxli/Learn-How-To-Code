/*
Collections — Reference Solution

A valid solution should:
- compile successfully;
- demonstrate List, MutableList, Set, Map, iteration, map/filter;
- use clear names and Kotlin conventions;
- handle the task's requested edge case.

Compare your solution for correctness and readability rather than exact text.
*/

fun main() {
    val nums = listOf(1,2,3,4)
    println(nums.filter { it % 2 == 0 }.map { it * 10 })
}
