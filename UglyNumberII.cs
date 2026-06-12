using System.Diagnostics;

namespace AlgoritmaSoruları;

/*
 * An ugly number is a positive integer whose prime factors are limited to 2, 3, and 5.
   
   Given an integer n, return the nth ugly number.
   
   Input: n = 10
   Output: 12
   Explanation: [1, 2, 3, 4, 5, 6, 8, 9, 10, 12] is the sequence of the first 10 ugly numbers.
 
 * Her pointer icin sıradaki adayını hesapla
 * Adaylardan en küçük olanı bul ve diziye ekle
 * Kazanan işaretçiyi (veya işaretçileri) bir adım ileri taşı
 */
public class UglyNumberII
{
    public static int NthUglyNumber(int n)
    {
        Stopwatch kronometre = new Stopwatch();
        kronometre.Start();
        
        int[] ugly = new int[n];
        ugly[0] = 1;

        int p2 = 0, p3 = 0, p5 = 0;

        for (int i = 1; i < n; i++) {
            
             
            int next2 = ugly[p2] * 2;
            int next3 = ugly[p3] * 3;
            int next5 = ugly[p5] * 5;

           
            int nextUgly = Math.Min(next2, Math.Min(next3, next5));
            ugly[i] = nextUgly;

            
            if (nextUgly == next2) p2++;
            if (nextUgly == next3) p3++;
            if (nextUgly == next5) p5++;
        }

        kronometre.Stop();
        Console.WriteLine($"Geçen Süre: {kronometre.ElapsedMilliseconds} ms");
        return ugly[^1];
    }
}