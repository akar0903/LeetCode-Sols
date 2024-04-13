public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] ans = new int[n];
        Array.Fill(ans,0);
        int pro =1;
        int zero =0;
        foreach(var num in nums){
            if(num==0){
                zero++;
                continue;
            }
            pro*=num;
        }
        if(zero==1){
            for(int i=0;i<n;i++){
                ans[i]=nums[i]==0?pro:0;
            }
        }
        else if(zero==0){
            for(int i=0;i<n;i++){
                ans[i]=pro/nums[i];
            }
        }
        return ans;

        
    }
}
