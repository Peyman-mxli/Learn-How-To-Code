using System;

static long Fib(int n)
{
    if (n <= 1) return n;
    long a = 0, b = 1;
    for (int i = 2; i <= n; i++)
    {
        (a, b) = (b, a + b);
    }
    return b;
}
Console.WriteLine(Fib(20));
