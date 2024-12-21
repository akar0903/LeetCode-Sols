public class Solution {
    public int MinElement(int[] nums) {
        var min = int.MaxValue;
        for(int i=0;i<nums.Length;i++){
            var sum = 0;
            var temp = nums[i];
            while(temp > 0){
                sum += (temp % 10);
                temp /= 10;
            }
            min = Math.Min(min,sum); 
        }
        return min;
    }
}
