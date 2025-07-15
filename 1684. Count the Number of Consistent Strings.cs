public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        HashSet<char> allowedSet = new HashSet<char>(allowed);
        int count = 0;
        foreach(string word in words){
            for(int i=0;i<word.Length;i++){
                if(!allowedSet.Contains(word[i])){
                    break;
                }
                else if(i == word.Length - 1){
                    count++;
                }
            }
        }
        return count;
    }
}
