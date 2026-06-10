namespace AlgoritmaSoruları;

public class Program
{
    public static void Main()
    {
        // var input = new List<int>{2,3,-5,4,1};
        // Console.WriteLine(SubarrayClosestToZero.SubarrayClosestToZeroAsJson(input));

        //Console.WriteLine(LongestAlternatingParitySubarray.LongestAlternatingParitySubarrayAsJson(input));

        int[] input1 = {1,2};
        int[] input2 = {3,4};

        double result = MedianOfTwoSortedArrays.FindMedianSortedArrays(input1, input2);
        Console.WriteLine(string.Join(", ", result));
    }
}