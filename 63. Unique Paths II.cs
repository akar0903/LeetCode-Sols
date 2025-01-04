public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        int m = obstacleGrid.Length;
        int n = obstacleGrid[0].Length;
        if(obstacleGrid[0][0] == 1){
            return 0;
        }
        int[,] dp = new int[m,n];
        dp[0,0] = 1;
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(obstacleGrid[i][j] == 1){
                    dp[i,j] = 0;
                }
                else{
                    if(i > 0){
                        dp[i,j] += dp[i-1,j];
                    }
                    if(j > 0){
                        dp[i,j] += dp[i,j-1];
                    }
                }
            }
        }
        return dp[m-1,n-1];
    }
}
