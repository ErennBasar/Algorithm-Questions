namespace AlgoritmaSoruları;
/*
 * Letters are case sensitive, for example, "Aa" is not considered a palindrome.
   
   Example 1:
   
   Input: s = "abccccdd"
   Output: 7
   Explanation: One longest palindrome that can be built is "dccaccd", whose length is 7.
 */
public class LongestPalindrome
{
    public static int LongestPalindrome_(string s)
    {
        int longestPalindrome = 0;
        bool control = false;

        int[] map = new int[128];

        for (int i = 0; i < s.Length; i++)
        {
            map[s[i]]++;
        }

        for (int i = 0; i < map.Length; i++)
        {
            if (map[i] > 0)
            {
                longestPalindrome += (map[i] / 2) * 2;
                
                if (map[i] % 2 == 1)
                {
                    control = true;
                }
            }
            
        }
        if (control)
        {
            longestPalindrome++;
        }

        return longestPalindrome;
    }
}