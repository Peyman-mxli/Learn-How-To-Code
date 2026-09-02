using System;

int[] a = { 2, 1, 5, 1, 3, 2 };
int k = 3;
int sum = 0;
for (int i = 0; i < k; i++) sum += a[i];
int best = sum;
for (int i = k; i < a.Length; i++)
{
    sum += a[i] - a[i-k];
    best = Math.Max(best, sum);
}
Console.WriteLine(best);
