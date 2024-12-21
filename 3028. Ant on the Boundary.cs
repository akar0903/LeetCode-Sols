public class Solution
{
    public int ReturnToBoundaryCount(int[] nums)
    {
        int position = 0; 
        int count = 0;   
        foreach (var i in nums)
        {
            position += i; 
            if (position == 0) 
            {
                count++;
            }
        }

        return count; 
    }
}
