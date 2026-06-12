namespace AlgoritmaSoruları;

public class BullsAndCows
{
    public static string GetHint(string secret, string guess)
    {
        int bulls = 0;
        int cows = 0;

        int[] count = new int[10];

        // bulls'lar varsa eklenir ve kalan secret elemanlari count icine eklenir 
        for (int i = 0; i < secret.Length; i++) 
        {
            if (guess[i] == secret[i])
            {
                bulls++;
            }
            else
            {
                count[secret[i] - '0']++;
            }
        }

        // cow olabilir mi kontrolu
        for (int i = 0; i < guess.Length; i++)
        {
            // rakanlar ayni degilse tahminin rakami count icinde var mi?
            if (guess[i] != secret[i])
            {
                int digit = guess[i] - '0';

                if (count[digit] > 0)
                {
                    cows++;
                    count[digit]--;
                }
            }
        }
        
        return $"{bulls}A{cows}B";
    }
}