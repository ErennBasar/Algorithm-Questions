using System.Text.Json;

namespace AlgoritmaSoruları;

public class LongestAlternatingParitySubarray
{
    public static string LongestAlternatingParitySubarrayAsJson(List<int>? numbers)
    {
        if (numbers == null || numbers.Count == 0)
        {
            return "[]";
        }

        var bestSubarray = new List<List<int>>();
        var evenOrOddArray = new List<int>();
        var currentArray = new List<int>();

        foreach (var number in numbers)
        {
            evenOrOddArray.Add(number % 2 == 0 ? 1 : 0);
            if (currentArray.Count == 0)
            {
                currentArray.Add(number);
            }
            else if(evenOrOddArray.Last() != evenOrOddArray[evenOrOddArray.Count - 2])
            {
                currentArray.Add(number);
            }
            else
            {
                bestSubarray.Add(currentArray);
                currentArray = new List<int> { number };

            }
        }
        bestSubarray.Add(currentArray);

        var best = bestSubarray
            .OrderByDescending(a => a.Count)
            .ThenByDescending(a => a.Sum())
            .FirstOrDefault();

        return JsonSerializer.Serialize(best);
    }
}