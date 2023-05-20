using System.Text;

namespace Practice.Codewars;

public static class Kyu7
{
    #region Compare 2 digit numbers (No solution)

    public static string Compare(int a, int b)
    {
        string zeroProc = "0%";
        string fiftyProc = "50%";
        string oneHundredProc = "100%";

        string aStr = a.ToString();
        string bStr = b.ToString();

        int result = aStr.Count(x => bStr.Contains(x));

        if (result == aStr.Length)
        {
            return oneHundredProc;
        }

        if (result < aStr.Length && result > 0)
        {
            return fiftyProc;
        }

        return zeroProc;
    }

    #endregion

    #region Length and two values.

    public static object[] Alternate(int n, object firstValue, object secondValue)
    {
        object[] resultArr = Array.Empty<object>();

        if (n == 0)
        {
            return resultArr;
        }

        for (int i = 0; i < n; i++)
        {
            resultArr = i % 2 != 0
                ? resultArr.Append(secondValue).ToArray()
                : resultArr.Append(firstValue).ToArray();
        }

        return resultArr;
    }

    #endregion

    #region Disemvowel Trolls

    public static string Disemvowel(string str)
    {
        char[] chArr = {'a', 'e', 'i', 'o', 'u'};

        return chArr.Aggregate(str, (current, c) => 
            current.Replace(c.ToString(), string.Empty, StringComparison.InvariantCultureIgnoreCase));
    }

    #endregion
}