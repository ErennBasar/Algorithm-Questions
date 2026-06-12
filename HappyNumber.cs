using System.Diagnostics;

namespace AlgoritmaSoruları;
/*
 * Input: n = 19
   Output: true
   Explanation:
   12 + 92 = 82
   82 + 22 = 68
   62 + 82 = 100
   12 + 02 + 02 = 1
 *
 */
public class HappyNumber
{
    public static bool IsHappy(int n)
    {
        Stopwatch sw = new();
        sw.Start();
        double result = 0;
        HashSet<int> results = new();
        
        while (result != 1 && !results.Contains(n))
        {
            
            results.Add(n);
            
            int digits = n == 0 ? 1 : (int)Math.Floor(Math.Log10(n)) + 1;
            double[] num = new double[digits];

            num[0] = Math.Pow((n % 10),2);

            for (int i = 1; i < digits; i++)
            {
                double basamak = Math.Pow(10, i);
                double x = Math.Floor(n / basamak) % 10;
                num[i] = Math.Pow(x, 2);
            }

            result = 0;
            for (int i = 0; i < digits; i++)
            {
                result += num[i];
            }
            
            n = (int)result;
        }

        sw.Stop();
        Console.WriteLine($"Geçen Süre: {sw.ElapsedMilliseconds} ms");
        Console.WriteLine($"Geçen Süre: {sw.ElapsedTicks} tick");
        return result == 1;
    }
}