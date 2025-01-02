public class Solution {
    public int MaxCoins(int[] nums) {
        int n = nums.Length;
        int[] balloons = new int[n+2];
        balloons[0] = 1;
        balloons[n + 1] = 1;
        for(int i=0;i<n;i++){
            balloons[i+1] = nums[i];
        }
        int[,] dp = new int[n+2,n+2];
        for(int length=2;length<n+2;length++){
            for(int left = 0;left< n + 2 - length;left++){
                int right = left+length;
                for(int k=left+1;k<right;k++){
                    dp[left,right] = Math.Max(dp[left,right],dp[left, k] + balloons[left] * balloons[k] * balloons[right] + dp[k, right]);
                }
            }
        }
        return dp[0,n+1];
        
    }
}
