public class Solution
{
    public IList<IList<string>> Partition(string s)
    {
        IList<IList<string>> result = new List<IList<string>>();
        void Backtrack(int start, List<string> currentPartition)
        {
            if (start == s.Length)
            {
                result.Add(new List<string>(currentPartition));
                return;
            }
            for (int end = start; end < s.Length; end++)
            {
                if (IsPalindrome(s, start, end))
                {
                    currentPartition.Add(s.Substring(start, end - start + 1));
                    Backtrack(end + 1, currentPartition);
                    currentPartition.RemoveAt(currentPartition.Count - 1);
                }
            }
        }
        bool IsPalindrome(string str, int left, int right)
        {
            while (left < right)
            {
                if (str[left] != str[right]) return false;
                left++;
                right--;
            }
            return true;
        }
        Backtrack(0, new List<string>());
        return result;
    }
}
