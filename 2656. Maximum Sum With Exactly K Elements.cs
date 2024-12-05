public class Solution {
    public int MaximizeSum(int[] nums, int k) {
        // int Max = int.MinValue;
        // for(int i=0;i<nums.Length;i++){
        //     if(nums[i]>Max){
        //         Max = nums[i];
        //     }
        // }
        // int sum=0;
        // for(int j=0;j<k;j++){
        //     sum += Max + 1;
        // }
        // return sum;
        return nums.Max()*k + (k*(k-1))/2;
    }
}
