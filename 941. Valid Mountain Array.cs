public class Solution {
    public bool ValidMountainArray(int[] arr) {
        if(arr.Length < 3){
            return false;
        }
        int i = 0;
        while(i + 1  < arr.Length - 1 && arr[i+1] > arr[i]){
            i++;
        }
        while(i > 0 && i + 1 <= arr.Length - 1 && arr[i] > arr[i+1]){
            i++;
        }
        return i == arr.Length-1;
    }
}
