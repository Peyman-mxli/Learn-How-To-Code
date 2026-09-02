using System;

int amount = 87;
int[] coins = { 25, 10, 5, 1 };
foreach (int coin in coins)
{
    int count = amount / coin;
    amount %= coin;
    Console.WriteLine($"{coin}: {count}");
}
