namespace AlgoritmaSoruları;

public class TwoSum
{
    public static int[] TwoSumWithLoop(int[] nums, int target) 
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int n = target - nums[i];

            for (int j = i+1; j < nums.Length; j++)
            {
                if (nums[j] == n)
                {
                    return new int[] { i, j };
                }
            }
        }

        return new int[]{};
    }

    public static int[] TwoSumWithHashTable(int[] nums, int target)
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int n = target - nums[i];
            if (dictionary.ContainsKey(n))
            {
                return new int[] { dictionary[n], i };
            }

            dictionary[nums[i]] = i; // Dictionary'ye yazdirma islemi
        }

        return new int[] { };
    }
}