public class Solution {
    public int FindGCD(int[] nums) {
        int min = int.MaxValue;
        int max = int.MinValue;
        for(int i=0;i<nums.Length;i++){
            if(nums[i] < min){
                min = nums[i];
            }
            if(nums[i] > max){
                max = nums[i];
            }
        }
        return GCD(min, max);
    }
    private int GCD(int a, int b) {
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
