using System.Globalization;

namespace AlgoritmaSoruları;

public class Program
{
    public static void Main()
    {
        // var input = new List<int>{2,3,-5,4,1};
        // Console.WriteLine(SubarrayClosestToZero.SubarrayClosestToZeroAsJson(input));

        //Console.WriteLine(LongestAlternatingParitySubarray.LongestAlternatingParitySubarrayAsJson(input));

        // int[] input1 = {1,2};
        // int[] input2 = {3,4};
        //
        // double result = MedianOfTwoSortedArrays.FindMedianSortedArrays(input1, input2);
        // Console.WriteLine(string.Join(", ", result));

        // int[] input = { 2, 11, 7, 15 };
        // int input2 = 9;
        //
        // int[] result = TwoSum.TwoSumWithLoop(input, input2);
        // Console.WriteLine($"[{string.Join(",", result)}]");
        //
        // int[] result2 = TwoSum.TwoSumWithHashTable(input, input2);
        // Console.WriteLine($"[{string.Join(",", result2)}]");

        // string s = "abcabcbb"; //3 
        // //string s = "bbbbb"; // 1
        // //string s = ""pwwkew""; // 3
        // int result = LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(s);
        // Console.WriteLine(result);

        // string secret = "1807";
        // string guess = "7810"; //1A3B
   
        // string secret = "1123";
        // string guess = "0111"; //1A1B
        //
        // string result = BullsAndCows.GetHint(secret, guess);
        // Console.WriteLine(result);

        // int uglyNum = 1407; //536870912 Geçen Süre: 0 ms
        // int result = UglyNumberII.NthUglyNumber(uglyNum);
        // Console.WriteLine(result);

        // int isHappy = 2; //false
        // int isHappy = 19; //true
        //
        // bool result = HappyNumber.IsHappy(isHappy);
        // Console.WriteLine(result);

        // ListNode dugum1 = new ListNode(3);
        // ListNode dugum2 = new ListNode(2);
        // ListNode dugum3 = new ListNode(0);
        // ListNode dugum4 = new ListNode(-4);
        //
        // dugum1.next = dugum2; 
        // dugum2.next = dugum3; 
        // dugum3.next = dugum4; 
        // dugum4.next = dugum2;
        //
        // bool result = LinkedListCycle.HasCycle(dugum1);
        // Console.WriteLine($"Listede kısır döngü var mı? : {result}");

        // int[] nums = { 5,2,5,1,5,7,5 };
        // int result = MajorityElement.MajorityElement_(nums);
        // Console.WriteLine(result);

        // string t = "b23";
        // string s = "s11";
        // bool result = IsomorphicStrings.IsIsomorphic(s,t);
        // Console.WriteLine(result);

        // int[] nums = { 1, 2, 3, 1 };
        // bool result = ContainsDuplicate.ContainsDuplicate_(nums);
        // Console.WriteLine(result);

        // int[] nums = { 1,0,1,1 };
        // int k = 1;
        // bool result = ContainsDuplicateII.ContainsNearbyDuplicate(nums,k);
        // Console.WriteLine(result);
        
        // int[] nums = { 2,1,1,3,1,4,5,6};
        // IList<int> result = MajorityElementII.MajorityElement(nums);
        // Console.WriteLine($"n/3 Barajını Geçenler: [{string.Join(", ", result)}]");

        // string t = "rat";
        // string s = "car";
        // bool result = ValidAnagram.IsAnagram(t,s);
        // Console.WriteLine(result);

        // int[] nums = { 9, 6, 4, 2, 3, 5, 7, 8, 1};
        // int result = MissingNumber.MissingNumber_(nums);
        // Console.WriteLine(result);

        // int[] nums = { 1,2,3 };
        // int target = 4;
        // long result = CountSubarraysWithMajorityElementII.CountMajoritySubarrays(nums, target);
        // Console.WriteLine(result);

        // string pattern = "abba";
        // string s = "dog dog dog dog";
        // bool result = WordPattern.WordPattern_(pattern, s);
        // Console.WriteLine(result);

        // string paragraph = "a.";
        // string[] banned = { " "};
        // string result = MostCommonWord.MostCommonWord_(paragraph, banned);
        // Console.WriteLine(result);
        

        // int[] nums1 = { 4, 9, 5 };
        // int[] nums2 = { 9, 4, 9, 8, 4 };
        // int[] result = IntersectionofTwoArrays.Intersection(nums1, nums2);
        // Console.WriteLine($"[{string.Join(", ", result)}]");
  
        // int[] nums1 = { 4,7,9,7,6,7 };
        // int[] nums2 = { 5,0,0,6,1,6,2,2,4};
        // int[] result = IntersectionOfTwoArrays_II.Intersect(nums1, nums2);
        // Console.WriteLine($"[{string.Join(", ", result)}]");

        // string ransomNote = "aa";
        // string magazine = "aab";
        // bool result = RansomNote.CanConstruct(ransomNote, magazine);
        // Console.WriteLine(result);

        // string s = "loveleetcode";
        // int result = FirstUniqueCharacterInAString.FirstUniqChar(s);
        // Console.WriteLine(result);

        string s = "abcd";
        string t = "adbce";
        char result = FindTheDifference.FindTheDifference_XOR(s, t);
        Console.WriteLine(result);

    }
}