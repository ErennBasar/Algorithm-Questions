namespace AlgoritmaSoruları;

public class CountSubarraysWithMajorityElementII
{
    public static long CountMajoritySubarrays(int[] nums, int target)
    {
        int n = nums.Length;
        
        int offset = n + 2; 
        
        int[] bit = new int[2 * n + 3];
        long sonuc = 0;
        int mevcutBakiye = 0;
        
        void Ekle(int indeks, int deger) 
        {
            for (; indeks < bit.Length; indeks += indeks & -indeks) 
            {
                bit[indeks] += deger;
            }
        }
        
        int Sorgula(int indeks) 
        {
            int toplam = 0;
            for (; indeks > 0; indeks -= indeks & -indeks) 
            {
                toplam += bit[indeks];
            }
            return toplam;
        }
        
        Ekle(0 + offset, 1);

        foreach (int sayi in nums) 
        {
            mevcutBakiye += (sayi == target) ? 1 : -1;
            
            sonuc += Sorgula(mevcutBakiye - 1 + offset);
            
            Ekle(mevcutBakiye + offset, 1);
        }

        return sonuc;
    }
}