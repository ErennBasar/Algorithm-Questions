using System.Xml.Schema;

namespace AlgoritmaSoruları;

/*
 Given two strings s and t, determine if they are isomorphic.
   
   Two strings s and t are isomorphic if the characters in s can be replaced to get t.
   
   All occurrences of a character must be replaced with another character while preserving the 
   
   order of characters. No two characters may map to the same character, 
   
   but a character may map to itself.
 */

/*
 * Input: s = "f11", t = "b23"
   
   Output: false
   
   Explanation:
   
   The strings s and t can not be made identical as '1' needs to be mapped to both '2' and '3'.
 */

public class IsomorphicStrings
{
    public static bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, char> map = new();
        HashSet<char> kullanilmisHedefler = new();

        for (int i = 0; i < s.Length; i++)
        {
            char kaynak = s[i];
            char hedef = t[i];

            if (map.TryGetValue(kaynak,out char eskiHedef ))
            {
                if (eskiHedef != hedef)
                {
                    return false;
                }
            }
            else
            {
                if (kullanilmisHedefler.Contains(hedef))
                {
                    return false;
                }

                map[kaynak] = hedef;
                kullanilmisHedefler.Add(hedef);
            }
        }

        return true;
    }
}