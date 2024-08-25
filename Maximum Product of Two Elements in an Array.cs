public class Solution {
    public int MaxProduct(int[] nums) {
        int max1 = int.MinValue;
        int max2 = int.MinValue;
        foreach(int num in nums)
        {
            if(num >= max1){
                max2=max1;
                max1=num;
            }
            else if(num>max2){
                max2=num;
            }
        }
        return (max1 - 1) * (max2 - 1);
    }
}
