namespace Practice.Codewars;

public static class Kyu8
{
    #region Return Negative

    public static int MakeNegative(int number)
    {
        return number <= 0
            ? number
            : -number;
    }

    #endregion

    #region Returning Strings

    public static string Greet(string name)
    {
        string resultString = $"Hello, {name} how are you doing today?";

        return resultString;
    }

    #endregion

    #region Opposite number

    public static int Opposite(int number)
    {
        return number > 0
            ? -Math.Abs(number)
            : Math.Abs(number);
    }

    #endregion

    #region Find Multiples of a Number

    public static List<int> FindMultiples(int integer, int limit)
    {
        List<int> resultValue = new();

        for (int i = integer; i <= limit; i += integer)
        {
            resultValue.Add(i);
        }

        return resultValue;
    }

    #endregion

    #region Twice as old

    public static int TwiceAsOld(int dadYears, int sonYears)
    {
        int ageAtBirth = dadYears - sonYears;

        int twiceAsOld = ageAtBirth * 2;

        return dadYears >= twiceAsOld
            ? dadYears - twiceAsOld
            : twiceAsOld - dadYears;
    }

    #endregion

    #region Sum of positive

    public static int PositiveSum(int[] arr)
    {
        int resultSum = 0;

        foreach (int i in arr)
        {
            if (i >= 0)
            {
                resultSum += i;
            }
        }

        return resultSum;
    }

    #endregion

    #region Convert number to reversed array of digits

    public static long[] Digitize(long n)
    {
        char[] numbersToStr = n.ToString().Reverse().ToArray();

        List<long> result = new();
        for (int i = 0; i < numbersToStr.Length - 1; i++)
        {
            // result.Add(numbersToStr.);
        }

        return result.ToArray();
    }

    #endregion
}