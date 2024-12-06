public class Solution
        {
            public int DeleteGreatestValue(int[][] grid)
            {
                int result = 0;
                foreach (int[] row in grid)
                {
                    Array.Sort(row);
                }

                for(int i = 0; i < grid[0].Length ; i++)
                {
                    int max = 0;
                    for(int j = 0;j<grid.Length ;j++)
                    {
                        if (max < grid[j][i])
                            max = grid[j][i]; 
                    }
                    result = result + max;
                }

                return result;
            }
        }
