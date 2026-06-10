using System.Text.Json;

namespace AlgoritmaSoruları;

public class LongestIncreasingSubarrayByLengthThenSum
{
    public static string LongestIncreasingSubarrayByLengthThenSumAsJson(List<int>? numbers)
    {
        if (numbers == null || numbers.Count == 0)
        {
            return "[]";
        }

        var bestSubArray = new List<List<int>>();
        var currentSubArray = new List<int>();

        foreach (var number in numbers)
        {
            if (currentSubArray.Count == 0 || number > currentSubArray.Last())
            {
                currentSubArray.Add(number);                 
            }
            else
            {
                bestSubArray.Add(currentSubArray);
                currentSubArray = new List<int> { number };
            }
        }
        bestSubArray.Add(currentSubArray);
        
        var best = bestSubArray
            .OrderByDescending(a => a.Count)
            .ThenByDescending(a=>a.Sum())
            .FirstOrDefault();

        return JsonSerializer.Serialize(best);

    }
}