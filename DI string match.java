class Solution {
    public int[] diStringMatch(String s) {
        int size = s.length();
        int low = 0;
        int high = size;
        int[] output_arr = new int[size+1];
        for(int i=0;i<size;i++){
            if(s.charAt(i)=='I'){
                output_arr[i]=low++;
            } else{
                output_arr[i]=high--;
            }
        }
        output_arr[size]=high;
        return output_arr;
    }
}
