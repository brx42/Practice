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
}