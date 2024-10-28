public class Solution {
    public int FindNumbers(int[] nums) {
        int even = 0 ;
        foreach(var item in nums){
            if(item.ToString().Length % 2 == 0){
                even++;
            }
        }
        return even;
        
    }
}
