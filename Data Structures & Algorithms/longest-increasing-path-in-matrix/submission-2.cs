public class Solution {
    int[][] memo;
    int[][] _matrix;
    int rows, cols;
    int[][] dirs = new int[][]{ new[]{0,1}, new[]{0,-1}, new[]{1,0}, new[]{-1,0} };

    public int LongestIncreasingPath(int[][] matrix) {
        rows = matrix.Length;
        cols = matrix[0].Length;
        _matrix = matrix;

        memo = new int[rows][];
        for(int i = 0; i < rows; i++) memo[i] = new int[cols];

        int best = 0;
        for(int y = 0; y < rows; y++)
            for(int x = 0; x < cols; x++)
                best = Math.Max(best, DFS(y, x));
        return best;
    }

    int DFS(int y, int x){
        if(memo[y][x] != 0) return memo[y][x]; 
        int best = 1;
        foreach(var d in dirs){
            int ny = y+d[0];
            int nx = x+d[1];
            if(ny >= 0 && ny < rows && nx >= 0 && nx < cols){
                if(_matrix[ny][nx] > _matrix[y][x]){
                    best = Math.Max(best, 1+ DFS(ny,nx));
                }
            }
        }
        memo[y][x] = best;
        return best;
    }
}