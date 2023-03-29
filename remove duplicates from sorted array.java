class Solution {
    public int removeDuplicates(int[] num) {
        int j=1;
        for(int i=0;i<num.length-1;i++)
        {
            if(num[i]!=num[i+1])
            {
                num[j]=num[i+1];
                j++;
            }
        }
        return j;
        
    }
}
