using System;
class Program
{
    static int FindMinIndex(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] > nums[right])
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
        return left;     }
    static void Main(string[] args)
    {
        int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
        int minIndex = FindMinIndex(nums);
        Console.WriteLine("The index of the smallest element is: " + minIndex);
    }
}
