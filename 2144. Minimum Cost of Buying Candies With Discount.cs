public class Solution {
    public int MinimumCost(int[] cost) {
        Array.Sort(cost);
        Array.Reverse(cost);
        int sum = 0;
        for(int i = 0;i < cost.Length;i++){
            if ((i + 1) % 3 != 0) {
                sum += cost[i];
            }
        }
        return sum;
    }
}
