using System;
using System.Collections.Generic;

static long Fib(int n, Dictionary<int,long> memo)
{
    if(n<=1) return n;
    if(memo.TryGetValue(n,out var v)) return v;
    return memo[n]=Fib(n-1,memo)+Fib(n-2,memo);
}
Console.WriteLine(Fib(20,new()));
