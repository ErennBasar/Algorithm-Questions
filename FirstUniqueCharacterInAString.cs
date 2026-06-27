namespace AlgoritmaSoruları;
/*
 Given a string s, find the first non-repeating character in it and return its index. 
 If it does not exist, return -1.
 
 * Input: s = "loveleetcode"
   
   Output: 2
 */
public class FirstUniqueCharacterInAString
{
    public static int FirstUniqChar(string s)
    {
        int[] map = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            map[s[i] - 'a']++;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (map[s[i] - 'a'] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}