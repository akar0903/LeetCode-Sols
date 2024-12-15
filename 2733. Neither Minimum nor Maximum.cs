public class Solution {
    public int FindNonMinOrMax(int[] nums) {
        if(nums.Length <= 2){
            return -1;
        }
        int secondmin = int.MaxValue;
        int min = int.MaxValue;
        for(int i=0;i<nums.Length;i++){
            if(nums[i] < min){
                secondmin = min;
                min = nums[i];
            }
            else if(nums[i] < secondmin && nums[i] > min){
                secondmin = nums[i];
            }
        }
     return secondmin;
        // Array.Sort(nums);
        // var arr = nums.Distinct().ToArray();
        // return arr[1];
    }
}
