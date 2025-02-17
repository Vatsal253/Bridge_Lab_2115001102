using System;
class Program
{
    static int FindPeakElement(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] > nums[mid + 1])
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }
        return left; 
    }
    static void Main(string[] args)
    {
        int[] nums = { 1, 3, 20, 4, 1, 0 };

        int peakIndex = FindPeakElement(nums);

        Console.WriteLine("The index of a peak element is: " + peakIndex);
        Console.WriteLine("The peak element is: " + nums[peakIndex]);
    }
}
