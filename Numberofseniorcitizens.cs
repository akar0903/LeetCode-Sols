public class Solution {
    public int CountSeniors(string[] details) {
        int count=0;
        foreach(var customer in details){
             int age = int.Parse(customer.Substring(11, 2));
            if (age > 60) {
                count++;
            }
        }
        return count;

        
    }
}
