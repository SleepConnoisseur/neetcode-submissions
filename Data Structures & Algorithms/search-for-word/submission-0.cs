public class Solution {
    public bool Exist(char[][] board, string word) {
        
        var result = false;
        var visited = new HashSet<(int,int)>();

        for(int row = 0 ; row < board.Length ; row++){
            for(int col = 0; col < board[0].Length; col++){
                if(board[row][col] == word[0]){
                    if(visited.Add((row,col))){
                        DFS(board, row , col , word, 0);
                        if(result == true) return true;
                        visited.Remove((row,col));
                    }
                }
            }
        }

        return false;

        void DFS(char[][] board, int row, int col, string word, int wordIndex){
            if(wordIndex == word.Length -1){
                result = true;
                return;
            }

            if(row < board.Length - 1){
                if(board[row+1][col] == word[wordIndex+1] && visited.Add((row+1,col))){
                    DFS(board, row + 1 , col , word, wordIndex + 1);
                    visited.Remove((row+1,col));
                }
            }
            if(row > 0){
                if(board[row-1][col] == word[wordIndex+1] && visited.Add((row-1,col))){
                    DFS(board, row - 1 , col , word, wordIndex + 1);
                    visited.Remove((row-1,col));
                }
            }
            if(col < board[0].Length - 1){
                if(board[row][col+1] == word[wordIndex+1] && visited.Add((row,col+1))){
                    DFS(board, row , col + 1 , word, wordIndex + 1);
                    visited.Remove((row,col+1));
                }
            }
            if(col > 0){
                if(board[row][col-1] == word[wordIndex+1] && visited.Add((row,col-1))){
                    DFS(board, row , col - 1 , word, wordIndex + 1);
                    visited.Remove((row,col-1));
                }
            }
        }
    }
}