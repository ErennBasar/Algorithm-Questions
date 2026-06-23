namespace AlgoritmaSoruları;

public class ContainsDuplicate
{
    public static bool ContainsDuplicate_(int[] nums)
    {
        HashSet<int> map = new();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!map.Add(nums[i]))
            {
                return true;
            }
        }

        return false;
    }
}