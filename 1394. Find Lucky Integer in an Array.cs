public class Solution {
    public int FindLucky(int[] arr) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        foreach(int num in arr){
            if(dict.ContainsKey(num)){
                dict[num]++;
            }
            else{
                dict[num]=1;
            }
        }
        int largestlucky = -1;
        foreach(var kvp in dict){
            int num = kvp.Key;
            int count = kvp.Value;
            if(num == count){
                largestlucky = Math.Max(num,largestlucky);
            }
        }
        return largestlucky;
    }
}
