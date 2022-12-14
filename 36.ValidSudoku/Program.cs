//Input: board =
//[["5", "3", ".", ".", "7", ".", ".", ".", "."]
//,["6",".",".","1","9","5",".",".","."]
//,[".","9","8",".",".",".",".","6","."]
//,["8",".",".",".","6",".",".",".","3"]
//,["4",".",".","8",".","3",".",".","1"]
//,["7",".",".",".","2",".",".",".","6"]
//,[".","6",".",".",".",".","2","8","."]
//,[".",".",".","4","1","9",".",".","5"]
//,[".",".",".",".","8",".",".","7","9"]]
//Output: true
char[][] array = new char[9][];
array[0] = new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' };
array[1] = new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' };
array[2] = new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' };
array[3] = new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' };
array[4] = new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' };
array[5] = new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' };
array[6] = new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' };
array[7] = new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' };
array[8] = new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' };
var teste = new Solution().IsValidSudoku(array);


//Input: board =
//[["8", "3", ".", ".", "7", ".", ".", ".", "."]
//,["6",".",".","1","9","5",".",".","."]
//,[".","9","8",".",".",".",".","6","."]
//,["8",".",".",".","6",".",".",".","3"]
//,["4",".",".","8",".","3",".",".","1"]
//,["7",".",".",".","2",".",".",".","6"]
//,[".","6",".",".",".",".","2","8","."]
//,[".",".",".","4","1","9",".",".","5"]
//,[".",".",".",".","8",".",".","7","9"]]
//Output: false
//Explanation: Same as Example 1, except with the 5 in the top left corner being modified to 8. Since there are two 8's in the top left 3x3 sub-box, it is invalid.
array = new char[8][];
array[0] = new char[] { '8', '3', '.', '.', '7', '.', '.', '.', '.' };
array[1] = new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' };
array[2] = new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' };
array[3] = new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' };
array[4] = new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' };
array[5] = new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' };
array[6] = new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' };
array[7] = new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' };
array[8] = new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' };
teste = new Solution().IsValidSudoku(array);


public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        bool[,] rows = new bool[9, 10];
        bool[,] cols = new bool[9, 10];
        bool[,] boxes = new bool[9, 10];

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (board[i][j] != '.')
                    continue;

                if (rows[i, board[i][j] - 48] || cols[j, board[i][j] - 48] || boxes[(i / 3) * 3 + j / 3, board[i][j] - 48])
                    return false;

                rows[i, board[i][j] - 48] = true;
                cols[j, board[i][j] - 48] = true;
                boxes[(i / 3) * 3 + j / 3, board[i][j] - 48] = true;
            }
        }

        return true;
    }
}