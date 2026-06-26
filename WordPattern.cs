namespace AlgoritmaSoruları;

public class WordPattern
{
    public static bool WordPattern_(string pattern, string s)
    {
        string[] strings = s.Split(' ');

        if (pattern.Length != strings.Length)
        {
            return false;
        }
        
        Dictionary<char, string> map = new();
        HashSet<string> kullanilanKelimeler = new();
        
        for (int i = 0; i < pattern.Length; i++)
        {
            if (map.TryGetValue(pattern[i], out string value))
            {
                if (value != strings[i])
                {
                    return false;
                } 
            }
            else
            {
                if (kullanilanKelimeler.Contains(strings[i]))
                {
                    return false;
                }
                
                map[pattern[i]] = strings[i];
                kullanilanKelimeler.Add(strings[i]);
            }
        }

        return true;
    }
}