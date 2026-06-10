namespace AlgoritmaSoruları;

public class MedianOfTwoSortedArrays
{
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2) { 
        int[] mergedArray = [..nums1, ..nums2];
        Array.Sort(mergedArray);

        int n = mergedArray.Length;

        if (n % 2 != 0)
        {
            return mergedArray[n / 2];
        }

        return (mergedArray[n / 2] + mergedArray[n / 2 - 1]) / 2.0;
    }
}