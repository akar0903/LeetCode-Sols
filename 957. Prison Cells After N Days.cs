public class Solution
{
    public int[] PrisonAfterNDays(int[] cells, int n)
    {
        var nextStateCells = new int[8];
        n %= 14;
        n += 14;
        for (int day = 0; day < n; day++)
        {
            for (int i = 1; i < 7; i++)
            {
                nextStateCells[i] = 1 - (cells[i - 1] ^ cells[i + 1]);
            }
            nextStateCells.CopyTo(cells, 0);
        }
        return cells;
    }
}
