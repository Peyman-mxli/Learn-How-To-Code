/*
 * File: 10-KOTLIN/01-INTRODUCTION-TO-KOTLIN/Examples.kt
 * Type: Examples
 *
 * Author: Peyman Miyandashti
 * University: Polytechnic University of Baja California
 * Program: Information Technology Engineering & Digital Innovation
 * Origin: Iran (Mexico)
 * Year: 2026
 */

package introductiontokotlin

/*
=====================================================
EXAMPLE 1
The First Kotlin Program
=====================================================
*/

fun main() {
    println("Hello, World!")
}

/*
Output:
Hello, World!
*/


/*
=====================================================
EXAMPLE 2
Printing Multiple Lines
=====================================================
*/

fun multipleLinesExample() {
    println("Welcome to Kotlin!")
    println("I am learning Kotlin with IntelliJ IDEA.")
    println("Programming is fun.")
}

/*
Output:
Welcome to Kotlin!
I am learning Kotlin with IntelliJ IDEA.
Programming is fun.
*/


/*
=====================================================
EXAMPLE 3
Understanding fun
=====================================================
*/

fun sayHello() {
    println("Hello from a function!")
}

/*
Calling the function:

sayHello()

Output:
Hello from a function!
*/


/*
=====================================================
EXAMPLE 4
Understanding main()
=====================================================
*/

fun mainExample() {
    println("Programs start from main().")
}

/*
Explanation:

main() is the entry point of a Kotlin application.
The JVM starts executing the program here.
*/


/*
=====================================================
EXAMPLE 5
Using println()
=====================================================
*/

fun printlnExample() {
    println("This text appears on the console.")
}

/*
Output:
This text appears on the console.
*/


/*
=====================================================
EXAMPLE 6
Common Mistake: Misspelled println
=====================================================
*/

// Wrong
// prntln("Hello")

// Correct
fun correctedPrintln() {
    println("Hello")
}


/*
=====================================================
EXAMPLE 7
Common Mistake: Missing Parentheses
=====================================================
*/

// Wrong
// println "Hello"

// Correct
fun correctedParentheses() {
    println("Hello")
}


/*
=====================================================
EXAMPLE 8
Common Mistake: Extra Braces
=====================================================
*/

// Wrong
/*
fun brokenProgram() {
    println("Hello")
}}
*/

// Correct

fun fixedProgram() {
    println("Hello")
}


/*
=====================================================
EXAMPLE 9
Personalized Greeting
=====================================================
*/

fun greetingExample() {
    println("Hello Peyman!")
    println("Welcome to Kotlin 2026.")
}

/*
Output:
Hello Peyman!
Welcome to Kotlin 2026.
*/


/*
=====================================================
EXAMPLE 10
Motivational Example
=====================================================
*/

fun motivationExample() {
    println("Every expert was once a beginner.")
    println("Keep practicing Kotlin every day.")
}

/*
Output:
Every expert was once a beginner.
Keep practicing Kotlin every day.
*/


/*
END OF EXAMPLES
*/
