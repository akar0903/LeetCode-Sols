public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for(int i=0;i<arr.Length;i++){
            if(dict.ContainsKey(arr[i])){
                dict[arr[i]]++;
            }
            else{
                dict[arr[i]] = 1;
            }
        }
        HashSet<int> occurrences = new HashSet<int>();
        foreach (var pair in dict) {
            occurrences.Add(pair.Value);
        }
        return occurrences.Count == dict.Count;

        
    }
}
