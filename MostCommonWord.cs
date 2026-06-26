namespace AlgoritmaSoruları;

public class MostCommonWord
{
    public static string MostCommonWord_(string paragraph, string[] banned)
    {
        paragraph = paragraph.ToLower();
        char[] ayiricilar = new char[] { ' ', '!', '?', '\'', ',', ';', '.' };
        string[] strings = paragraph.Split(ayiricilar, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> map = new();
        HashSet<string> yasak = new(banned);
        
        string enCokGecenKelime = "";
        int maxTekrar = 0;
        
        for (int i = 0; i < strings.Length; i++)
        {
            string kelime = strings[i];
            
            if (!yasak.Contains(kelime))
            {
                map.TryGetValue(kelime, out int value);
                map[kelime] = value + 1;
                
                if (map[kelime] > maxTekrar)
                {
                    maxTekrar = map[kelime];
                    enCokGecenKelime = kelime;
                }
            }
        }

        return enCokGecenKelime;
    }
}