public class Solution {
    public int MostWordsFound(string[] sentences) {
        //int count =0;
        int maxcount = 0;
         foreach (string sentence in sentences) {
            int count = sentence.Split(' ').Length;
            if (count > maxcount)
            {
                maxcount = count;
            }
        }
        return maxcount;
        
    }
}
