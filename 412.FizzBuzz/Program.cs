//Input: n = 3
//Output: ["1","2","Fizz"]
foreach (var item in new Solution().FizzBuzz(3))
{
    Console.WriteLine(item);
}
Console.WriteLine("");

//Input: n = 5
//Output: ["1","2","Fizz","4","Buzz"]
foreach (var item in new Solution().FizzBuzz(5))
{
    Console.WriteLine(item);
}
Console.WriteLine("");

//Input: n = 15
//Output: ["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"]
foreach (var item in new Solution().FizzBuzz(15))
{
    Console.WriteLine(item);
}
Console.WriteLine("");


public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        string[] strArr = new string[n];

        for (int i = 0; i < n; i++)
        {
            if ((i+1) % 3 == 0)
                strArr[i] += "Fizz";

            if ((i+1) % 5 == 0)
                strArr[i] += "Buzz";

            if (strArr[i] == null)
                strArr[i] = (i+1).ToString();
        }

        return strArr.ToList();
    }
}