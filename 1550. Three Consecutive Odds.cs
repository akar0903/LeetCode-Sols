public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        int n = arr.Length;
        if(n <= 2){
            return false;
        }
        for (int i = 0; i < n - 2; i++) {
        if (arr[i] % 2 != 0 && arr[i + 1] % 2 != 0 && arr[i + 2] % 2 != 0) {
            return true;
        }
    }
        return false;
    }
}
