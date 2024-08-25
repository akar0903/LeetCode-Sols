public class Solution {
    public int DifferenceOfSum(int[] nums) {
        int length = nums.Length;
        int sum=0;
        int sum_ind=0;
        for(int i=0;i<length;i++)
        {
            sum += nums[i];
        }
        foreach (int num in nums)
        {
            foreach (char digit in num.ToString())
            {
                sum_ind += (digit - '0'); 
            }
        }
        return sum-sum_ind;
    }
}
