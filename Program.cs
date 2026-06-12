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

        //int isHappy = 2; //false
        int isHappy = 19; //true
        
        bool result = HappyNumber.IsHappy(isHappy);
        Console.WriteLine(result);

    }
}