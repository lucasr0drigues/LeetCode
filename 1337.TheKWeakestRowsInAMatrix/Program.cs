//Input: mat =
//[[1, 1, 0, 0, 0],
// [1,1,1,1,0],
// [1,0,0,0,0],
// [1,1,0,0,0],
// [1,1,1,1,1]], 
//k = 3
//Output: [2,0,3]
int[][] mat = new int[][] {
    new int[] { 1, 1, 0, 0, 0 },
    new int[] { 1, 1, 1, 1, 0 },
    new int[] { 1, 0, 0, 0, 0 },
    new int[] { 1, 1, 0, 0, 0 },
    new int[] { 1, 1, 1, 1, 1 }};
Array.ForEach(new Solution().KWeakestRows(mat, 3), Console.WriteLine);
Console.WriteLine("");

//Input: mat =
//[[1, 0, 0, 0],
// [1,1,1,1],
// [1,0,0,0],
// [1,0,0,0]], 
//k = 2
//Output: [0,2]
int[][] mat2 = new int[][] {
    new int[] {1, 0, 0, 0 },
    new int[] { 1,1,1,1 },
    new int[] { 1,0,0,0 },
    new int[] { 1,0,0,0 }};
Array.ForEach(new Solution().KWeakestRows(mat2, 2), Console.WriteLine);
Console.WriteLine("");

//[[1,0],[1,0],[1,0],[1,1]]
//4
int[][] mat3 = new int[][] {
    new int[] {1,0 },
    new int[] { 1,0 },
    new int[] { 1,0 },
    new int[] { 1,1 }};
Array.ForEach(new Solution().KWeakestRows(mat3, 4), Console.WriteLine);
Console.WriteLine("");

public class Solution
{
    public int[] KWeakestRows(int[][] mat, int k)
    {
        var rows = mat.Length;
        var columns = mat[0].Length;
        int[] kCount = new int[rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (mat[i][j] == 0)
                    break;
                kCount[i] += 1;
            }

            kCount[i] = (kCount[i] * rows) + i;
        }

        Array.Sort(kCount);
        int[] answer = new int[k];

        for (int i = 0; i < k; i++)
        {
            answer[i] = kCount[i] % rows;
        }

        return answer;

    }
}