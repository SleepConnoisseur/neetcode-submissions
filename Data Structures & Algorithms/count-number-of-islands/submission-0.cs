public class Solution {
    HashSet<(int,int)> visited = new HashSet<(int,int)>();

    public int NumIslands(char[][] grid) {
        int islandCount = 0;

        for(int row  = 0 ; row < grid.Length; row++){
            for(int column = 0; column < grid[0].Length; column++){
                if(grid[row][column] == '1' && !visited.Contains((row,column))){
                    
                    islandDFS(grid,row,column);

                    islandCount += 1;
                }
            }
        }

        return islandCount;
    }

    public void islandDFS(char[][] grid, int row, int column){
        if(grid[row][column] == '0') return;
        visited.Add((row,column));

        if(row - 1 >= 0 && !visited.Contains((row -1 ,column))) islandDFS(grid,row-1,column);
        if(row + 1 < grid.Length && !visited.Contains((row +1 ,column))) islandDFS(grid,row+1,column);
        if(column - 1 >= 0 && !visited.Contains((row,column -1 ))) islandDFS(grid,row,column-1);
        if(column + 1 < grid[0].Length && !visited.Contains((row,column +1 ))) islandDFS(grid,row,column+1);
    }
}
