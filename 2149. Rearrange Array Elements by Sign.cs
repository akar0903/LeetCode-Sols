public class Solution {
    public int[] RearrangeArray(int[] nums) {
        //Array.Sort(nums);
        int n = nums.Length;
        int[] result = new int[n];
        int positive =0;
        int negative = 1;
        foreach(int num in nums){
            if(num >= 0){
                result[positive] = num;
                positive += 2;
            }
            else{
                result[negative] = num;
                negative += 2;
            }
        }
        return result;
    }
}
