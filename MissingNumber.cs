namespace AlgoritmaSoruları;

/*
 * Given an array nums containing n distinct numbers in the range [0, n],
   return the only number in the range that is missing from the array.
 *
 * Input: nums = [9,6,4,2,3,5,7,0,1]
   
   Output: 8
   
   Explanation:
   
   n = 9 since there are 9 numbers, so all numbers are in the range [0,9]. 
   8 is the missing number in the range since it does not appear in nums.
 */
 
public class MissingNumber
{
    public static int MissingNumber_(int[] nums) 
    {
        Array.Sort(nums);
        if (nums.Length == 1)
        {
            if (nums[0] == 1)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i+1] - nums[i] != 1)
            {
                return nums[i+1]-1;
            }
            if (nums[^1] != nums.Length)
            {
                return nums[^1] + 1;
            }
            
        }

        return 0;
    }
}