namespace AlgoritmaSoruları;

/*
 * Given two integer arrays nums1 and nums2, return an array of their intersection.
 * Each element in the result must be unique and you may return the result in any order.
 *
 * Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
   Output: [9,4]
   Explanation: [4,9] is also accepted.
 */
public class IntersectionofTwoArrays
{
    public static int[] Intersection(int[] nums1, int[] nums2)
    {
        /*
         * bool[] map = new bool[1001];
         *
         * sayilar 1000'den fazla olamayacagi icin 1000 odali var mi yok mu dizisi olusturulur 0ms icin.
         *
         * nums1'deki tum sayilari odalara yerlestirip isikleri aciyoruz
         * (kesisimler gecici bir dizide tutulur(int[]))
         * nums2'deki sayi eger odalardan birindeyse sayaci 1 arttirip isigini kapatiyoruz
         *
         * return sonuc[..sayac];
         */ 
        
        HashSet<int> map = new(nums1);
        HashSet<int> gorulen = new();

        for (int i = 0; i < nums2.Length; i++)
        {
            if (map.Contains(nums2[i]))
            { 
                gorulen.Add(nums2[i]);
            }
        }

        return gorulen.ToArray();
    }
}