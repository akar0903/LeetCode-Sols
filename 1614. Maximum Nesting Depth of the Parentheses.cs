public class Solution {
    public int MaxDepth(string s) {
        int currentDepth = 0;
        int maxDepth = 0;
        foreach(char c in s){
            if(c == '('){
                currentDepth++;
                maxDepth = Math.Max(currentDepth,maxDepth);
            }
            if(c == ')'){
                currentDepth--;
            }
        }
        return maxDepth;
        
    }
}
