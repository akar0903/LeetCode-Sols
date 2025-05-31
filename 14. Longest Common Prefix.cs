public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs == null || strs.Length == 0){
            return "";
        }
        string prefix = strs[0];
        foreach(string word in strs){
            while(!word.StartsWith(prefix)){
                if(prefix.Length == 0){
                    return "";
                }
                prefix = prefix.Substring(0,prefix.Length-1);
            }
        }
        return prefix;
        
    }
}
