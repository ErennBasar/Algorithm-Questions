namespace AlgoritmaSoruları;

public class MajorityElementII
{
    public static IList<int> MajorityElement(int[] nums)
    {
        int majorityElement_1 = 0;
        int majorityElement_2 = 0;

        int counter_1 = 0;
        int counter_2 = 0;

        for (int i = 0; i < nums.Length; i++) // [2,1,1,3,1,4,5,6]
        {
            if (counter_1 == 0 && nums[i] != majorityElement_2)
            {
                majorityElement_1 = nums[i];
                counter_1++;
                continue;
            }
            if (counter_2 == 0 && nums[i] != majorityElement_1)
            {
                majorityElement_2 = nums[i];
                counter_2++;
                continue;
            }
            if (nums[i] == majorityElement_1 )
            {
                counter_1++;
            }
            else if (nums[i] == majorityElement_2)
            {
                counter_2++;
            }
            else if (counter_1 > 0 && counter_2 > 0)
            {
                counter_1--;
                counter_2--;
            }

        }

        counter_1 = 0;
        counter_2 = 0;
        foreach (int num in nums)
        {
            if (num == majorityElement_1)
            {
                counter_1++;
            }
            else if (num == majorityElement_2)
            {
                counter_2++;
            }
        }

        int k = nums.Length / 3;
        List<int> majorityElements = new();

        if (counter_1 > k) majorityElements.Add(majorityElement_1);
        if (counter_2 > k) majorityElements.Add(majorityElement_2);

        return majorityElements;
    }
}
    
