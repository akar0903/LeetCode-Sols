public class Solution {
    public int CoinChange(int[] coins, int amount) {
        int[] dp = new int[amount + 1];
        for (int i = 0; i <= amount; i++) {
            dp[i] = int.MaxValue; 
        }
        dp[0] = 0; 
        foreach (int coin in coins) {
            for (int i = coin; i <= amount; i++) {
                if (dp[i - coin] != int.MaxValue) {
                    dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                }
            }
        }
        return dp[amount] == int.MaxValue ? -1 : dp[amount];
    }
}
