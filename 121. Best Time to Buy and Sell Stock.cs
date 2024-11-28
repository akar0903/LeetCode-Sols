public class Solution {
    public int MaxProfit(int[] prices) {
        int min = prices[0];
        int max = 0;
        int n = prices.Length;
        for(int i=1;i<n;i++){
            int profit = prices[i] - min;
            max = Math.Max(profit,max);
            min = Math.Min(min, prices[i]);
        }
        return max;
    }
}
