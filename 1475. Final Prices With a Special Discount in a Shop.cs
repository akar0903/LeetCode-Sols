public class Solution {
    public int[] FinalPrices(int[] prices) {
        int n = prices.Length;
        int[] result = new int[n]; 
        for (int i = 0; i < n; i++)
        {
            result[i] = prices[i]; 
            for (int j = i + 1; j < n; j++)
            {
                if (prices[j] <= prices[i])
                {
                    result[i] = prices[i] - prices[j]; 
                    break; 
                }
            }
        }
        return result;
    }
}
