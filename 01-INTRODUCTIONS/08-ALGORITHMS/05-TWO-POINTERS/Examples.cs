using System;

int[] nums = { 1, 2, 4, 7, 11 };
int target = 9;
int left = 0, right = nums.Length - 1;
while (left < right)
{
    int sum = nums[left] + nums[right];
    if (sum == target) { Console.WriteLine($"{nums[left]} + {nums[right]}"); break; }
    if (sum < target) left++; else right--;
}
