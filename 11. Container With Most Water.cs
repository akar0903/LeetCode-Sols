public class Solution {
    public int MaxArea(int[] height) {
        int maxarea = 0;
        int left = 0;
        int right = height.Length-1;
        while(left < right){
            int currentarea = Math.Min(height[right],height[left]) * (right-left);
            maxarea = Math.Max(maxarea,currentarea);
            if(height[left] <height[right]){
                left++;
            }
            else{
                right--;
            }
        }
        return maxarea;
    }
}
