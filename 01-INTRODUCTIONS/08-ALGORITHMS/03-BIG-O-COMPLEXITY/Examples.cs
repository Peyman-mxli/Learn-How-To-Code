using System;

int[] values = { 1, 2, 3, 4, 5 };
Console.WriteLine(values[0]); // O(1)

foreach (var value in values) Console.WriteLine(value); // O(n)

for (int i = 0; i < values.Length; i++)
    for (int j = 0; j < values.Length; j++)
        _ = values[i] + values[j]; // O(n^2)
