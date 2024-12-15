public class Solution {
    public int FindSpecialInteger(int[] arr) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        int n = arr.Length;
        for(int i=0;i<arr.Length;i++){
            if(dict.ContainsKey(arr[i])){
                dict[arr[i]]++;
            }
            else{
                dict[arr[i]] = 1;
            }
        }
        foreach (var kvp in dict) {
            if ((float)kvp.Value / n > 0.25) {
                return kvp.Key;
            }
        }
        return 0;
    }
}
