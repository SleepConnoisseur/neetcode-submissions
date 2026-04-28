public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
{
    if (matrix != null)
    {
        int rowLen = Math.Max(0, matrix[0].Length - 1);
        int maxBoundry = matrix.Length - 1;
        int minBoundry = 0;

        int x = (minBoundry + maxBoundry) / 2;

        while (minBoundry <= maxBoundry)
        {
            x = (minBoundry + maxBoundry) / 2;
            if (matrix[x][0] <= target && target <= matrix[x][rowLen])
            {
                for (int a = 0, b = rowLen; a <= b;)
                {
                    int i = (a + b) / 2;
                    if (matrix[x][i] == target) return true;
                    else if (matrix[x][i] < target)
                    {
                        a = i + 1;
                    }
                    else
                    {
                        b = i - 1;
                    }
                }
                return false;
            }
            else if (matrix[x][0] < target)
            {
                minBoundry = x + 1;
            }
            else
            {
                maxBoundry = x - 1;
            }
        }
    }
    return false;
}
}
