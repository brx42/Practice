namespace Practice.Codewars;

public static class Kyu6
{
    #region Does my number look big in this?

    public static bool Narcissistic(int value)
    {
        string valueToStr = value.ToString();
        int valueLength = valueToStr.Length;

        double result = 0;

        for (int i = 0; i <= valueLength - 1; i++)
        {
            int valIndex = Convert.ToInt32(valueToStr[i] - 48);

            double valDegree = Math.Pow(valIndex, valueLength);

            result += valDegree;
        }

        return value == (int)result;
    }

    #endregion
}