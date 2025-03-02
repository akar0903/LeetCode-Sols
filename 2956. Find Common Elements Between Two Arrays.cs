public class Solution {
    public int[] FindIntersectionValues(int[] nums1, int[] nums2) {
        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> set2 = new HashSet<int>(nums2);
        int ans1 = 0;
        int ans2 = 0;
        foreach(int num in nums1){
            if(set2.Contains(num)){
                ans1++;
            }
        }
        foreach(int num in nums2){
            if(set1.Contains(num)){
                ans2++;
            }
        }
        return new int[] { ans1, ans2 };
    }
}
