public class Solution {
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3) {
        HashSet<int> nums = new HashSet<int>();
        foreach(int num in nums1){
            if(nums2.Contains(num) || nums3.Contains(num)){
                nums.Add(num);
            }
        }
        foreach(int num in nums2){
            if(nums1.Contains(num) || nums3.Contains(num)){
                nums.Add(num);
            }
        }
        foreach(int num in nums3){
            if(nums2.Contains(num) || nums1.Contains(num)){
                nums.Add(num);
            }
        }
        return nums.ToArray();
    }
}
