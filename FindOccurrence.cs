using System;
class Program
{
    static int FindFirstOccurrence(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                result = mid;
                right = mid - 1; // Search in the left half
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

        return result;
    }

    static int FindLastOccurrence(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                result = mid;
                left = mid + 1; // Search in the right half
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

        return result;
    }

    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 2, 2, 3, 4, 5 };
        int target = 2;

        int firstOccurrence = FindFirstOccurrence(nums, target);
        int lastOccurrence = FindLastOccurrence(nums, target);

        Console.WriteLine("First occurrence of " + target + " is at index: " + firstOccurrence);
        Console.WriteLine("Last occurrence of " + target + " is at index: " + lastOccurrence);
    }
}
