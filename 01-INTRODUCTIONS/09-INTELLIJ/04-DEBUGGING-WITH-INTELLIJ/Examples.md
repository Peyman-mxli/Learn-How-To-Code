# Debugging with IntelliJ IDEA — Examples

## Example 1 — Inspect a function

~~~kotlin
fun calculateTotal(price: Int, quantity: Int): Int {
    val subtotal = price * quantity
    val discount = 10
    return subtotal - discount
}

fun main() {
    val total = calculateTotal(price = 25, quantity = 3)
    println("Total: $total")
}
~~~

Procedure:

1. Set a breakpoint on the subtotal assignment.
2. Start Debug.
3. Inspect price and quantity.
4. Step Over and inspect subtotal.
5. Add a watch for subtotal - discount.
6. Step Over to the return line.
7. Step Out to main.
8. Inspect total.
9. Resume.

Expected values:

| Value | Result |
|---|---:|
| price | 25 |
| quantity | 3 |
| subtotal | 75 |
| discount | 10 |
| total | 65 |

## Example 2 — Find an incorrect average

Defective code:

~~~kotlin
fun average(total: Int, count: Int): Int {
    return total / (count + 1)
}

fun main() {
    val result = average(total = 40, count = 4)
    println("Average: $result")
}
~~~

Expected average: 10  
Actual average: 8

Debugging evidence:

- total is 40;
- count is 4;
- the divisor becomes 5;
- the first incorrect operation is count + 1.

Correction:

~~~kotlin
fun average(total: Int, count: Int): Int {
    return total / count
}
~~~

## Example 3 — Step Into and Step Out

~~~kotlin
fun square(number: Int): Int {
    return number * number
}

fun main() {
    val result = square(6)
    println(result)
}
~~~

Pause on the call to square. Step Into enters square. Step Out finishes square and returns to main, where result becomes 36.

## Example 4 — Conditional loop breakpoint

~~~kotlin
fun main() {
    var total = 0

    for (number in 1..10) {
        total += number
        println("number=$number total=$total")
    }
}
~~~

Place a breakpoint on total += number with condition:

~~~kotlin
number == 7
~~~

Expected paused state before the addition:

- number: 7
- total: 21

After Step Over, total becomes 28.

## Example 5 — Diagnose a branch

~~~kotlin
fun accessMessage(age: Int): String {
    return if (age >= 18) {
        "Access granted"
    } else {
        "Access denied"
    }
}

fun main() {
    println(accessMessage(17))
}
~~~

Inspect age and Step Over the condition. The else branch is correct because 17 is below 18.

## Example 6 — Null-safe observation

~~~kotlin
fun displayLength(text: String?) {
    val length = text?.length ?: 0
    println("Length: $length")
}

fun main() {
    displayLength(null)
}
~~~

Inspect text before evaluating length. Expected text is null and length is 0.

## Example 7 — Avoid sensitive screenshots

Suppose a variable contains an API token. Do not share the Variables panel. Provide safe evidence:

~~~text
Breakpoint reached: Yes
Authentication branch inspected: Yes
Sensitive value omitted: Yes
Root cause: Missing environment configuration
~~~

## Navigation

- [Lesson overview](./README.md)
- [Notes](./Notes.md)
- [Tasks](./Tasks.md)
