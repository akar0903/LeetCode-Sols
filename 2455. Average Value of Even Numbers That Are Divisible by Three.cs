public class Solution {
    public int AverageValue(int[] nums) {
        int sum = 0;
        int count =0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i] % 2 == 0 && nums[i] % 3 == 0){
                count++;
                sum += nums[i];
            }
        }
        if(count != 0){
            return sum / count;
        }
        return 0;
    }
}
