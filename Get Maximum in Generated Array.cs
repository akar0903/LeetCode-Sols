public class Solution {
    public int GetMaximumGenerated(int n) {
        if(n==0){
            return 0;
        }
        int[] nums = new int[n+1];
        nums[1]=1;
        int max=1;
        for(int i=2;i<=n;i++){
            nums[i]=nums[i/2]+ i % 2 * nums[i/2 +1];
            max = Math.Max(max,nums[i]); 
        }
        return max;
    }
}
