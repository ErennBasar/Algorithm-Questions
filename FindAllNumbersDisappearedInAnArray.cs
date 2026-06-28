namespace AlgoritmaSoruları;
/*
 * Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range [1, n] that do not appear in nums.
   
   Example 1:
   
   Input: nums = [4,3,2,7,8,2,3,1]
   Output: [5,6]
 */
public class FindAllNumbersDisappearedInAnArray
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        bool[] map = new bool[nums.Length + 1];

        foreach (int num in nums)
        {
            map[num] = true;
        }

        List<int> lostNumbers = new List<int>();
        
        for (int i = 1; i <= nums.Length; i++)
        {
            if (map[i] == false)
            {
                lostNumbers.Add(i);
            }
        }

        return lostNumbers;
    }
}