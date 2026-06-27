namespace AlgoritmaSoruları;

/*
 * Input: ransomNote = "aa", magazine = "aab"
   Output: true
 */
public class RansomNote
{
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        if (ransomNote.Length > magazine.Length)
        {
            return false;
        }
        
        int[] map = new int[256];
        int counter = ransomNote.Length;

        for (int i = 0; i < ransomNote.Length; i++)
        {
            map[ransomNote[i]]++;
        }

        for (int i = 0; i < magazine.Length; i++)
        {
            if (map[magazine[i]] > 0)
            {
                map[magazine[i]]--;
                counter--;
                if (counter == 0)
                {
                    return true;
                }
            }
        }

        return false;
    }
}