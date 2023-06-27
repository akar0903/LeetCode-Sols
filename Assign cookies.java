class Solution {
    public int findContentChildren(int[] g, int[] s) {
        Arrays.sort(g);
        Arrays.sort(s);
        int a_point=0;
        int b_point=0;
        while(a_point<g.length && b_point < s.length){
            if(g[a_point]<=s[b_point]){
                a_point++;
                b_point++;
            }
            else{
                b_point++;
            }
        }
        return a_point;
        
    }
}
