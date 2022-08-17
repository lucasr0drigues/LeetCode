//Input: s = "III"
//Output: 3
//Explanation: III = 3.
Console.WriteLine(new Solution().RomanToInt("III"));

//Input: s = "I"
//Output: 1
//Explanation: I = 1.
Console.WriteLine(new Solution().RomanToInt("I"));

//Input: s = "LVIII"
//Output: 58
//Explanation: L = 50, V = 5, III = 3.
Console.WriteLine(new Solution().RomanToInt("LVIII"));

//Input: s = "MCMXCIV"
//Output: 1994
//Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
Console.WriteLine(new Solution().RomanToInt("MCMXCIV"));

public class Solution
{
    public int RomanToInt(string s)
    {
        int total = 0;
        int anterior = 0;
        int valor;

        for (int i = 0; i < s.Length; i++)
        {
            valor = ValueInt(s[i]);

            if (valor > anterior && i>0)
                total += valor - anterior*2;
            else
                total += valor;

            anterior = valor;
        }

        return total;
    }

    public int ValueInt(char s)
    {
        if (s == 'I')
            return 1;
        else if (s == 'V')
            return 5;
        else if (s == 'X')
            return 10;
        else if (s == 'L')
            return 50;
        else if (s == 'C')
            return 100;
        else if (s == 'D')
            return 500;
        else if (s == 'M')
            return 1000;
        else
            return 0;

    }
}