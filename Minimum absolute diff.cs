public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        Array.Sort(arr);
        List<IList<int>> list = new List<IList<int>>();
        int mindiff = arr[1]-arr[0];
        for(int i=1;i<arr.Length;i++){
            mindiff = Math.Min(mindiff,arr[i]-arr[i-1]);
        } 
        for(int i=1;i<arr.Length;i++){
            if(arr[i]-arr[i-1] == mindiff){
                list.Add(new List<int> {arr[i-1],arr[i]});
            }
        }
        return list;
    }
}
