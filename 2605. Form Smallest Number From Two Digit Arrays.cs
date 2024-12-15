public class Solution {
    public int MinNumber(int[] nums1, int[] nums2) {
        int min = int.MaxValue;
        int result =0;
        int min1 = int.MaxValue;
        int minNumber = int.MaxValue;
        bool isTrue = false;
        for(int i=0;i<nums1.Length;i++){
            for(int j=0;j<nums2.Length;j++){
                if(nums1[i] == nums2[j]){
                    if(minNumber > nums1[i]){
                        minNumber = nums1[i];
                        isTrue = true;
                    }
                }
                if(min > nums1[i]){
                    min = nums1[i];
                }
                if(min1  > nums2[j]){
                    min1 = nums2[j];
                }
            }
        }
        if(isTrue){
            return minNumber;
        }
        if(min >= min1){
            string concatenated = min1.ToString() + min.ToString();
            result = int.Parse(concatenated);
            return result;
        }
        if(min1 > min){
            string concatenated = min.ToString() + min1.ToString();
            result = int.Parse(concatenated);
            return result;
        }
        return -1;
    }
}
