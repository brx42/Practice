namespace Practice.Codewars;

public static class Kyu7
{
    #region Compare 2 digit numbers

    public static string Compare(int a, int b)
    {
        string zeroProc = "0%";
        string fiftyProc = "50%";
        string oneHundredProc = "100%";

        string aStr = a.ToString();
        string bStr = b.ToString();
        
        int result = aStr.Count(x => bStr.Contains(x));

        if (result == 2)
        {
            return oneHundredProc;
        }

        return result == 1 ? fiftyProc : zeroProc;
    }

    #endregion
}