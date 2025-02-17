using System;
class Program
{
    static int FindFirstMissingPositive(int[] nums)
    {
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            if (nums[i] <= 0 || nums[i] > n)
            {
                nums[i] = n + 1;
            }
        }
        for (int i = 0; i < n; i++)
        {
            int num = Math.Abs(nums[i]);
            if (num <= n)
            {
                nums[num - 1] = -Math.Abs(nums[num - 1]);
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (nums[i] > 0)
            {
                return i + 1;
            }
        }

        return n + 1;
    }
    static int BinarySearch(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }
    static void Main(string[] args)
    {
        int[] nums = { 3, 4, -1, 1 };
        int firstMissingPositive = FindFirstMissingPositive(nums);
        Console.WriteLine("First missing positive integer: " + firstMissingPositive);
        Array.Sort(nums);
        int target = 3;
        int targetIndex = BinarySearch(nums, target);

        if (targetIndex != -1)
        {
            Console.WriteLine("Index of target number " + target + " is: " + targetIndex);
        }
        else
        {
            Console.WriteLine("Target number " + target + " not found in the array.");
        }
    }
}
