using System.Diagnostics.Tracing;

namespace AlgoritmaSoruları;

public class ContainsDuplicateII
{
    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int, int> map = new();

        for (int i = 0; i < nums.Length; i++)
        {
            
            if (map.TryGetValue(nums[i], out var eskiIndex))
            {
                if (i - eskiIndex <= k)
                {
                    return true;
                }
            }

            map[nums[i]] = i;
        }

        return false;
    }
}