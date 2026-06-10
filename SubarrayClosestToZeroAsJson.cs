using System.Text.Json;

namespace AlgoritmaSoruları;

public class SubarrayClosestToZero
{
    public static string SubarrayClosestToZeroAsJson(List<int>? numbers)
    {
        if (numbers == null || numbers.Count == 0)
        {
            return "[]";
        }

        var closestSubarray = new List<int>();
        int closestSum = int.MaxValue;

        for (int i = 2; i < numbers.Count; i++)
        {
            for (int j = 0; j <= numbers.Count - i; j++)
            {
                //geçerli alt dizi
                var currentSubarray = numbers.GetRange(j, i);
                
                //alt dizinin toplamı
                var currentSum = currentSubarray.Sum();
                
                //Toplamı 0 olan bir alt dizi bulunursa hemen döndür
                if (currentSum == 0)
                {
                    return JsonSerializer.Serialize(currentSubarray);
                }
                
                //Daha iyi bir toplam bulunursa sakla
                if (Math.Abs(currentSum) < Math.Abs(closestSum))
                {
                    closestSum = currentSum;
                    closestSubarray = currentSubarray;
                }
            }
        }

        return JsonSerializer.Serialize(closestSubarray);

        // var bestArray = new List<List<int>>();
        // var currentArray = new List<int>();
        // int? closestToZero = null ;
        //
        // foreach (var number in numbers)
        // {
        //     if (currentArray.Count == 0 )
        //     {
        //         currentArray.Add(number);
        //         closestToZero = currentArray.Sum();
        //     }
        //     else if (closestToZero + number == 0)
        //     {
        //         currentArray.Add(number);
        //         bestArray.Add(currentArray);
        //         currentArray = new List<int>();
        //     }
        //     else
        //     {
        //         //closestToZero += number;
        //         currentArray = new List<int> { number };
        //         closestToZero = number;
        //     }
        // }
        //
        // var best = bestArray
        //     .OrderBy(a => a.Count)
        //     .FirstOrDefault();
        //
        // return JsonSerializer.Serialize(best);
    }
}