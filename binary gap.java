class Solution {
    public int binaryGap(int n) {
        int res = 0;
        int lastPos = -1;
        int curpos = 0;
        while(n!=0){
            if((n&1)==1){
                if(lastPos != -1){
                    res = Math.max(res,curpos-lastPos);
                }
                lastPos = curpos;
            }
            curpos++;
            n>>=1;
        }
        return res;
        
    }
}
