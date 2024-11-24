public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int Max = 0;
        int Current = 0;
        foreach(var num in nums){
            if(num == 1){
                Current++;
                Max= Math.Max(Max,Current);
            }
            else{
                Current = 0;
            }
        }
        return Max;
    }
}
