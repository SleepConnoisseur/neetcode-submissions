public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var checkList = new List<char>(){'1','2','3','4','5','6','7','8','9','.'};
        var hashSetArray = Enumerable.Range(0, 27).Select(_ => new HashSet<char>()).ToArray();

        for(int row = 0; row < board.Length; row++){
            for(int col = 0; col < board.Length; col++){
                if(!checkList.Contains(board[row][col])) return false;
                if(board[row][col] == '.')continue;
                if(!hashSetArray[9+row].Add(board[row][col])) return false;
                if(!hashSetArray[18+col].Add(board[row][col])) return false;
                if(row < 3){
                    if(col < 3){
                        if(!hashSetArray[0].Add(board[row][col])) return false;
                    }
                    else if(col < 6){
                        if(!hashSetArray[1].Add(board[row][col])) return false;
                    }
                    else{
                        if(!hashSetArray[2].Add(board[row][col])) return false;
                    }
                }
                else if(row < 6){
                    if(col < 3){
                        if(!hashSetArray[3].Add(board[row][col])) return false;
                    }
                    else if(col < 6){
                        if(!hashSetArray[4].Add(board[row][col])) return false;
                    }
                    else{
                        if(!hashSetArray[5].Add(board[row][col])) return false;
                    }
                }
                else{
                    if(col < 3){
                        if(!hashSetArray[6].Add(board[row][col])) return false;
                    }
                    else if(col < 6){
                        if(!hashSetArray[7].Add(board[row][col])) return false;
                    }
                    else{
                        if(!hashSetArray[8].Add(board[row][col])) return false;
                    }
                }
            }

        }
        return true;
    }
}
