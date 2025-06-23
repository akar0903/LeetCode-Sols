public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        Dictionary<int,int> nextGreater = new Dictionary<int,int>();
        Stack<int> stack = new Stack<int>();
        foreach(int nums in nums2){
            while(stack.Count > 0 && nums > stack.Peek()){
                int smallest = stack.Pop();
                nextGreater[smallest] = nums;
            }
            stack.Push(nums);
        }
        while(stack.Count > 0){
            int rem = stack.Pop();
            nextGreater[rem] = -1;
        }
        int[] result = new int[nums1.Length];
        for(int i=0;i<nums1.Length;i++){
            result[i] = nextGreater[nums1[i]];
        }
        return result;
    }
}
