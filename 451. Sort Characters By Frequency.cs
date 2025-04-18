public class Solution {
    public string FrequencySort(string s) {
        Dictionary<char,int> freq = new Dictionary<char,int>();
        foreach(var c in s){
            if(freq.ContainsKey(c)){
                freq[c]++;
            }
            else{
                freq[c]=1;
            }
        }
        var sortedChars = freq.OrderByDescending(kw => kw.Value);
        StringBuilder result = new StringBuilder();
        foreach(var kw in sortedChars){
            result.Append(new String(kw.Key,kw.Value));
        }        
        return result.ToString();
    }
}
