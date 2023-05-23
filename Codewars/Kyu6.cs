using System.Reflection.Metadata;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

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

    #region Find the odd int

    public static int FindIt(int[] seq)
    {
        return seq
            .GroupBy(x => x)
            .First(x => x.Count() % 2 != 0)
            .Key;
    }

    #endregion

    #region Multiples of 3 or 5

    public static int Solution(int value)
    {
        if (value <= 0)
        {
            return 0;
        }

        List<int> values = new(value);

        for (int i = 0; i < value; i++)
        {
            values.Add(i);
        }

        return values
            .Where(x => x % 3 == 0
                        || x % 5 == 0)
            .Sum();
    }

    #endregion

    #region Stop gninnipS My sdroW!

    public static string SpinWords(string sentence)
    {
        string[] arrWords = sentence.Split();

        if (arrWords.Length == 1)
        {
            return string.Concat(arrWords.Single().Reverse());
        }

        StringBuilder result = new();
        
        for (int i = 0; i < arrWords.Length; i++)
        {
            result.Append(arrWords[i].Length >= 5
                ? string.Concat(arrWords[i].Reverse())
                : arrWords[i]);
        }

        return string.Join(' ', result.ToString());

        return result.ToString();

        StringBuilder strBuild = new();

        return arrWords.Aggregate(strBuild, (current, value) =>
            current.Append(value.Length >= 5 ? string.Concat(value.Reverse()) : value)).ToString();
    }

    #endregion
}