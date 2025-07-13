public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int maxWealth = 0;
        foreach(var customers in accounts){
            int sum = 0;
            foreach(var wealth in customers){
                sum += wealth;
            }
            if(sum > maxWealth){
                maxWealth = sum;
            }
        }
        return maxWealth;
    }
}
