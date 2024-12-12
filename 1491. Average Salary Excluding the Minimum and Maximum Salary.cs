public class Solution {
    public double Average(int[] salary) {
        Array.Sort(salary);
        double sum = 0;
        double elements = 0; 
        for(int i=1;i<salary.Length-1;i++){
            sum += salary[i];
            elements++;
        }
        return sum / elements;
        
    }
}
