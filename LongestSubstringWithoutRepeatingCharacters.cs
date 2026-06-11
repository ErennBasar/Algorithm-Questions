namespace AlgoritmaSoruları;

public class LongestSubstringWithoutRepeatingCharacters
{
    // Dictionary ve SlidingWindow kullan
    // left,right,max lazim olan degiskenler
    // Dongu ile kelimedeki tum harfleri gezeriz, her ilerlediginde dictionary'de o kelime var mi diye bakilir, 
    // eger varsa left ile pencere daraltilir(math.max(left, ilk tekrar eden harfin sozlukteki indexi + 1)),
    // yoksa dictionary'ye kaydedilir.
    // pencerenin uzunlugu maxLenght olarak kaydedilir
    public static int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> map = new();

        int left = 0;
        int maxLenght = 0;

        for (int right = 0; right < s.Length; right++)
        {
            char current = s[right];

            if (map.ContainsKey(current))
            {
                left = Math.Max(left, map[current] + 1);
            }

            map[current] = right;

            maxLenght = Math.Max(maxLenght, right - left + 1);
        }

        return maxLenght;
    }
    
}