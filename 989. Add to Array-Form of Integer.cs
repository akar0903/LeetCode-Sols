public class Solution {
    public IList<int> AddToArrayForm(int[] num, int k) {
        int carry = k;
        List<int> result = new List<int>();
        int i = num.Length - 1;
        while(i >= 0 || carry>0){
            if(i >= 0){
                carry += num[i];
                i--;
            }
            result.Add(carry % 10);
            carry /= 10;
        }
        result.Reverse();
        return result;
    }
}
