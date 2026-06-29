namespace AlgoritmaSoruları;
/*
 * Input: nums1 = [4,1,2], nums2 = [1,3,4,2]
   Output: [-1,3,-1]
   Explanation: The next greater element for each value of nums1 is as follows:
   - 4 is underlined in nums2 = [1,3,4,2]. There is no next greater element, so the answer is -1.
   - 1 is underlined in nums2 = [1,3,4,2]. The next greater element is 3.
   - 2 is underlined in nums2 = [1,3,4,2]. There is no next greater element, so the answer is -1.
 */
public class NextGreaterElementI
{
    public static int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> map = new();
        Stack<int> stack = new();

        foreach (int num in nums2)
        {
            while (stack.Count > 0 && stack.Peek() < num)
            {
                int low = stack.Pop();
                map[low] = num;
            }
            
            stack.Push(num);
        }

        int[] result = new int[nums1.Length];

        for (int i = 0; i < nums1.Length; i++)
        {
            if (map.TryGetValue(nums1[i], out int bigNum))
            {
                result[i] = bigNum;
            }
            else
            {
                result[i] = -1;
            }
        }

        return result;
    }
}