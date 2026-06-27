namespace AlgoritmaSoruları;

public class IntersectionOfTwoArrays_II
{
    public static int[] Intersect(int[] nums1, int[] nums2)
    {
        int[] map = new int[1001];
        int[] sonuc = new int[Math.Min(nums1.Length, nums2.Length)];
        int counter = 0;
        
        for (int i = 0; i < nums1.Length; i++) 
        {
            map[nums1[i]]++;
        }
        
        for (int i = 0; i < nums2.Length; i++)
        {
            if (map[nums2[i]] > 0) 
            {
                sonuc[counter] = nums2[i];
                counter++;
                map[nums2[i]]--;
            }
        }

        return sonuc[..counter];
    }
}