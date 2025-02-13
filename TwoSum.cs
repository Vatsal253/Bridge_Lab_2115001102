using System;
using System.Collections.Generic;

class Program
{
    static int[] FindTwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (numMap.ContainsKey(complement))
            {
                return new int[] { numMap[complement], i };
            }

            numMap[nums[i]] = i;
        }

        throw new ArgumentException("No two sum solution");
    }

    static void Main(string[] args)
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        try
        {
            int[] result = FindTwoSum(nums, target);
            Console.WriteLine("Indices: [" + result[0] + ", " + result[1] + "]");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
