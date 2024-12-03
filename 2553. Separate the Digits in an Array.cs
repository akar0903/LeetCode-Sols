public class Solution {
    public int[] SeparateDigits(int[] nums) {
        List<int> result = new List<int>();
        foreach(int num in nums){
            string numStr = num.ToString();
            foreach(char str in numStr){
                result.Add(str - '0');
            }
        }
        return result.ToArray();
    }
}
