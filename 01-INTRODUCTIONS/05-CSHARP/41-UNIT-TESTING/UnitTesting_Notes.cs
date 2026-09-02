using System;

/*
=========================================================
UNIT TESTING NOTES
=========================================================

Unit Testing is the process of testing small parts
of a program to make sure they work correctly.

A unit is usually:

- A method
- A class
- A small piece of logic

The goal is to check if one small part of the code
gives the correct result.

=========================================================
WHAT IS A UNIT TEST?
=========================================================

A unit test is code that tests other code.

Example:

If I have this method:

Add(2, 3)

The expected result is:

5

A unit test checks if the method really returns 5.

=========================================================
WHY UNIT TESTING IS IMPORTANT
=========================================================

Unit testing helps me:

- Find bugs early
- Check if my code works
- Protect old code when I make changes
- Improve confidence in my program
- Write cleaner code
- Build professional software

Without tests, I may change something and accidentally
break another part of the program.

=========================================================
WHAT CAN I TEST?
=========================================================

I can test:

- Math methods
- String methods
- Validation logic
- Business rules
- Class behavior
- Return values
- Error handling

Examples:

- Is the total price correct?
- Is the password valid?
- Is the username empty?
- Is the discount calculated correctly?

=========================================================
WHAT SHOULD A UNIT TEST DO?
=========================================================

A good unit test should:

- Test one thing
- Be easy to understand
- Have a clear expected result
- Run quickly
- Not depend on external systems
- Be repeatable

A unit test should not normally depend on:

- Databases
- Internet
- File system
- Random results
- Current time

Those things can make tests unstable.

=========================================================
THE ARRANGE, ACT, ASSERT PATTERN
=========================================================

Most unit tests follow this pattern:

1. Arrange
2. Act
3. Assert

---------------------------------------------------------
ARRANGE
---------------------------------------------------------

Prepare the data.

Example:

int a = 2;
int b = 3;

---------------------------------------------------------
ACT
---------------------------------------------------------

Run the method being tested.

Example:

int result = Add(a, b);

---------------------------------------------------------
ASSERT
---------------------------------------------------------

Check if the result is correct.

Example:

Expected result = 5
Actual result = result

If result is 5, the test passes.

If result is not 5, the test fails.

=========================================================
PASSING TEST
=========================================================

A test passes when the actual result matches
the expected result.

Example:

Expected: 5
Actual: 5

Result:

PASS

=========================================================
FAILING TEST
=========================================================

A test fails when the actual result does not match
the expected result.

Example:

Expected: 5
Actual: 6

Result:

FAIL

A failing test is helpful because it shows me
that something is wrong.

=========================================================
COMMON C# UNIT TESTING TOOLS
=========================================================

Professional C# projects often use:

1. xUnit
2. NUnit
3. MSTest

These tools help me write and run tests.

=========================================================
XUNIT
=========================================================

xUnit is a popular testing framework for .NET.

A basic xUnit test uses:

[Fact]

Example:

[Fact]
public void Add_ShouldReturnCorrectSum()
{
}

=========================================================
NUNIT
=========================================================

NUnit is another popular testing framework.

A basic NUnit test uses:

[Test]

Example:

[Test]
public void Add_ShouldReturnCorrectSum()
{
}

=========================================================
MSTEST
=========================================================

MSTest is Microsoft’s testing framework.

A basic MSTest test uses:

[TestMethod]

Example:

[TestMethod]
public void Add_ShouldReturnCorrectSum()
{
}

=========================================================
NAMING UNIT TESTS
=========================================================

Good test names should explain what is being tested.

Example:

Add_ShouldReturnCorrectSum()

This name means:

Method: Add
Expected behavior: Should return correct sum

Another common style:

MethodName_Condition_ExpectedResult

Example:

Divide_WhenDividingByZero_ShouldThrowException()

=========================================================
ASSERTIONS
=========================================================

Assertions check if the result is correct.

Examples:

- Are two values equal?
- Is a value true?
- Is a value false?
- Is an object null?
- Is an exception thrown?

In xUnit:

Assert.Equal(expected, actual);

In NUnit:

Assert.AreEqual(expected, actual);

In MSTest:

Assert.AreEqual(expected, actual);

=========================================================
TESTING RETURN VALUES
=========================================================

Example method:

public int Add(int a, int b)
{
    return a + b;
}

Test idea:

Input:

2 and 3

Expected output:

5

=========================================================
TESTING BOOLEAN METHODS
=========================================================

Example method:

public bool IsAdult(int age)
{
    return age >= 18;
}

Test ideas:

Age 20 should return true.

Age 10 should return false.

=========================================================
TESTING STRING METHODS
=========================================================

Example method:

public string GetFullName(string firstName, string lastName)
{
    return firstName + " " + lastName;
}

Test idea:

"Peyman" + "Miyandashti"

Expected:

"Peyman Miyandashti"

=========================================================
TESTING EXCEPTIONS
=========================================================

Sometimes I expect a method to throw an error.

Example:

Divide by zero should throw an exception.

A test can check that the exception happens correctly.

=========================================================
TESTING EDGE CASES
=========================================================

An edge case is a special situation.

Examples:

- Empty string
- Null value
- Zero
- Negative number
- Very large number
- Maximum limit
- Minimum limit

Good unit tests include normal cases and edge cases.

=========================================================
TESTING VALIDATION LOGIC
=========================================================

Example:

public bool IsValidPassword(string password)
{
    return password.Length >= 8;
}

Test ideas:

- "12345678" should be valid
- "123" should be invalid
- Empty password should be invalid

=========================================================
UNIT TESTING VS MANUAL TESTING
=========================================================

Manual testing means I test the program by hand.

Example:

Run the program
Type input
Look at output

Unit testing means code automatically checks the result.

Unit testing is faster and more reliable.

=========================================================
UNIT TESTING VS DEBUGGING
=========================================================

Debugging is finding and fixing a problem.

Unit testing helps detect the problem earlier.

They are different, but they work together.

=========================================================
TESTABLE CODE
=========================================================

Testable code is code that is easy to test.

Good testable code usually:

- Has small methods
- Has clear return values
- Does one thing
- Avoids too many hidden dependencies

=========================================================
BAD TESTING PRACTICES
=========================================================

Avoid:

- Testing too many things in one test
- Writing unclear test names
- Depending on random values
- Ignoring failing tests
- Testing implementation details too much
- Writing tests after every bug is already forgotten

=========================================================
BENEFITS OF UNIT TESTING
=========================================================

Unit testing helps me:

✓ Catch bugs early

✓ Refactor safely

✓ Understand code better

✓ Improve code design

✓ Reduce future errors

✓ Build professional habits

=========================================================
LIMITATIONS OF UNIT TESTING
=========================================================

Unit testing does not prove the entire application
is perfect.

It only tests small parts.

Other testing types may also be needed:

- Integration testing
- UI testing
- End-to-end testing
- Performance testing

=========================================================
REAL-WORLD USE CASES
=========================================================

Unit testing is used in:

- Banking software
- Web applications
- Game systems
- APIs
- Inventory systems
- Student management systems
- Business applications

Example:

In a game, I can test:

- Damage calculation
- Level up logic
- Inventory stacking
- Skill cooldowns

=========================================================
SUMMARY
=========================================================

Unit testing is the process of testing small parts
of my code automatically.

Important ideas:

- Unit
- Test
- Expected result
- Actual result
- Arrange
- Act
- Assert
- Passing test
- Failing test
- Edge cases
- Assertions

Unit testing helps me write safer, cleaner,
and more professional C# code.
*/

/*
👤 Author Peyman Miyandashti
📨 250161@upbc.edu.mx // mxli.peyman@gmail.com
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
