class Solution {
    public int minimumTotal(List<List<Integer>> traingle) {
        for(int i=1;i<traingle.size();i++){
            for(int j=0;j<traingle.get(i).size();j++){
                int sum = 0;
                if(j==0){
                    sum = traingle.get(i).get(j)+traingle.get(i-1).get(j);
                }
                else if(j == traingle.get(i).size()-1){
                    sum = traingle.get(i).get(j)+traingle.get(i-1).get(traingle.get(i-1).size()-1);
                }
                else{
                    int min = Math.min(traingle.get(i-1).get(j),traingle.get(i-1).get(j-1));
                    sum = min+traingle.get(i).get(j);
                }
                traingle.get(i).set(j,sum);
            }
        }
        return Collections.min(traingle.get(traingle.size()-1));
        
    }
}
