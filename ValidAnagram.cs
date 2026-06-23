namespace AlgoritmaSoruları;

public class ValidAnagram
{
    public static bool IsAnagram(string s, string t)
    {
        char[] chars = new char[256];

        for (int i = 0; i < s.Length; i++)
        {
            chars[s[i]]++;
        }

        for (int i = 0; i < t.Length; i++)
        {
            
            if (chars[t[i]] > 0)
            {
                chars[t[i]]--;
            }
            else
            {
                return false;
            }
        }
        
        foreach (char c in chars)
        {
            if (c != 0)
            {
                return false;
            }
        }
        
        return true;
    }
}