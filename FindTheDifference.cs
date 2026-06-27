using System.Diagnostics;

namespace AlgoritmaSoruları;
/*
 * Input: s = "abcd", t = "abcde"
   Output: "e"
   Explanation: 'e' is the letter that was added.
   
 */
public class FindTheDifference
{
    public static char FindTheDifference_Dictionary(string s, string t)
    {
        //Dictionary ile yapildiginda 5ms
        
        if (t.Length == 1)
        {
            return t[0];
        }
        
        Dictionary<char, int> map = new();
        
        for (int i = 0; i < s.Length; i++)
        {
            map.TryGetValue(s[i], out int value);
            map[s[i]] = value + 1;
        }
        
        for (int i = 0; i < t.Length; i++)
        {
            if (map.TryGetValue(t[i], out int value) && value > 0)
            {
                map[t[i]] = value - 1;
            }
            else
            {
                return t[i];
            }
        
        }
        
        return 'f';
        
    }

    public static char FindTheDifference_(string s, string t)
    {
        // Dinamik bellek yonetimi ile 1ms

        if (t.Length == 1)
        {
            return t[0];
        }
        
        int[] map = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            map[s[i] - 'a']++;
        }

        for (int i = 0; i < t.Length; i++)
        {
            if (map[t[i] - 'a'] > 0)
            {
                map[t[i] - 'a']--;
            }
            else
            {
                return t[i];
            }
        }

        throw new UnreachableException();
    }

    public static char FindTheDifference_XOR(string s, string t)
    {
        int result = 0;

        // s'deki harfleri kovaya at
        foreach (char c in s)
        {
            result = result ^ c;
        }

        // t'deki harfleri kovaya at (ikizler çarpışıp birbirini yok edecek)
        foreach (char c in t)
        {
            result = result ^ c;
        }

        // Geriye kalan tek değer
        return (char)result;
    }
}