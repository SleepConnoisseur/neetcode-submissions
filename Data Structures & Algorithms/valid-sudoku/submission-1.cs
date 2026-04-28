public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] sets = new HashSet<char>[27];
        for(int i = 0; i < sets.Length; i++) {
            sets[i] = new HashSet<char>();
        }
        //0-8 rows
        //9-17 columns
        //18-26 squares

        for(int row = 0; row < 9; row++){
            for(int column = 0; column < 9; column++){
                if(board[row][column] != '.'){
                    // add to row set
                    if(!sets[row].Add(board[row][column]))return false;
                    // add to column sets
                    if(!sets[column+9].Add(board[row][column]))return false;

                    if(row <= 2 && column <=2) {if(!sets[18].Add(board[row][column])) return false;}
                    else if(row <= 2 && column <=5) {if(!sets[19].Add(board[row][column])) return false;}
                    else if(row <= 2 && column <=8) {if(!sets[20].Add(board[row][column])) return false;}

                    else if(row <= 5 && column <=2) {if(!sets[21].Add(board[row][column])) return false;}
                    else if(row <= 5 && column <=5) {if(!sets[22].Add(board[row][column])) return false;}
                    else if(row <= 5 && column <=8) {if(!sets[23].Add(board[row][column])) return false;}

                    else if(row <= 8 && column <=2) {if(!sets[24].Add(board[row][column])) return false;}
                    else if(row <= 8 && column <=5) {if(!sets[25].Add(board[row][column])) return false;}
                    else if(row <= 8 && column <=8) {if(!sets[26].Add(board[row][column])) return false;}
                }
            }
        }
        return true;
    }
}
