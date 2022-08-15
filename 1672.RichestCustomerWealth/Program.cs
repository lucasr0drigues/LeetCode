Solution.teste();

public static class Solution
{
    //Input: accounts = [[1,2,3],[3,2,1]]
    //Output: 6
    static int[][] accounts1 = new int[][] { new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 } };

    //Input: accounts = [[1,5],[7,3],[3,5]]
    //Output: 10
    static int[][] accounts2 = new int[][] { new int[] { 1,5 }, new int[] { 7,3 }, new int[] { 3,5 } };

    //Input: accounts = [[2,8,7],[7,1,3],[1,9,5]]
    //Output: 17
    static int[][] accounts3 = new int[][] { new int[] { 2,8,7 }, new int[] { 7,1,3 }, new int[] { 1, 9, 5 } };

    public static void teste()
    {
        Console.WriteLine(MaximumWealth(accounts1));
        Console.WriteLine(MaximumWealth(accounts2));
        Console.WriteLine(MaximumWealth(accounts3));
    }
    public static int MaximumWealth(int[][] accounts)
    {
        var total = 0;
        var max = 0;

        for (var i = 0; i < accounts.Length; i++)
        {

            for (var j = 0; j < accounts[i].Length; j++)
            {
                total += accounts[i][j];
            }

            if (total > max)
                max = total;

            total = 0;
        }

        return max;
    }
}


