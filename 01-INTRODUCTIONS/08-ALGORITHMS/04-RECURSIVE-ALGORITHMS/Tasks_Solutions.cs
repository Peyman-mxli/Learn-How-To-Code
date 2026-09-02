using System;

static int SumTo(int n) => n <= 0 ? 0 : n + SumTo(n - 1);
Console.WriteLine(SumTo(5));
