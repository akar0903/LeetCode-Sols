public class Solution {
    public bool CanReorderDoubled(int[] arr) {
        var dict = new Dictionary<int,int>();
        for(int i=0;i<arr.Length;i++){
            if(dict.ContainsKey(arr[i])) dict[arr[i]]++;
            else dict.Add(arr[i],1);
        }
        if(dict.ContainsKey(0)){
            if(dict[0] % 2 !=0) return false;
            dict.Remove(0);
        }
        Array.Sort(arr);
        for(int i=0;i<arr.Length;i++){
            if(!dict.ContainsKey(arr[i])) continue;
            if(dict.ContainsKey(arr[i] * 2)){
                var min = Math.Min(dict[arr[i]],dict[arr[i] * 2]);
                dict[arr[i]] -= min;
                if(dict[arr[i]] == 0) dict.Remove(arr[i]);
                dict[arr[i] * 2] -= min;
                if(dict[arr[i] * 2] == 0) dict.Remove(arr[i] * 2);
            }
        }
        return dict.Count == 0;
    }
}
