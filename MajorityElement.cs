namespace AlgoritmaSoruları;

/*
 * Given an array nums of size n, return the majority element.
   
   The majority element is the element that appears more than ⌊n / 2⌋ times. 
   
   You may assume that the majority element always exists in the array.
   
   Example 1:
   
   Input: nums = [3,2,3]
   Output: 3
*/

/* Boyer-Moore'un Savaş Meydanı (Boyer-Moore Voting Algorithm)
 
 * Dizideki her bir sayıyı, farklı bir klanın askeri olarak düşün.
 
 * Aynı sayıdan olanlar aynı klandandır ve birbirlerini desteklerler.
 
 * Farklı sayılar ise düşmandır ve karşılaştıklarında birbirlerini yok ederler (ikisi de ölür).
 */
   
   
   
public class MajorityElement
{
    public static int MajorityElement_(int[] nums)
    {
        int majorityElement = nums[0];
        int counter = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (counter == 0)
            {
                majorityElement = nums[i];
                counter++;
                continue;
            }
            
            if (majorityElement != nums[i])
            {
                counter--;
            }
            else
            {
                counter++;
            }
        }

        return majorityElement;
    }
}