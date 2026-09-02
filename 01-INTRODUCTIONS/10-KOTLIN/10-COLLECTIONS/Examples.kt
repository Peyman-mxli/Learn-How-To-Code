fun main() {
    val nums = listOf(1,2,3,4)
    println(nums.filter { it % 2 == 0 }.map { it * 10 })
}
