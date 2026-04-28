public class Solution {
    int[][] _memo;
    int[][] _matrix;
    int _cols;
    int _rows;
    int[][] _dir = new int[][]{new int[]{0,1}, new int[]{0,-1}, new int[]{1,0}, new int[]{-1,0}};

    public int LongestIncreasingPath(int[][] matrix) {
        _matrix = matrix;
        _rows = matrix.Length;
        _cols = matrix[0].Length;     
        _memo = new int[_rows][];
        for(int i = 0; i < _rows; i++) _memo[i] = new int[_cols]; 

        var best = 0;
        for(int y = 0; y < _rows; y++)
            for(int x = 0; x < _cols; x++)
                best = Math.Max(best, DFS(y,x));
        return best;
    }

    int DFS(int y, int x){
        if(_memo[y][x] != 0) return _memo[y][x];
        var best = 1;
        foreach(var dir in _dir){
            var newY = y + dir[0];
            var newX = x + dir[1];
            if( newY >= 0 && newX >= 0 && newY < _rows && newX < _cols)
                if( _matrix[newY][newX] > _matrix[y][x])
                    best = Math.Max(best, 1 + DFS(newY,newX));
        }
        _memo[y][x] = best;
        return best;
    }
}
