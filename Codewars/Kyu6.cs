using System.Reflection.Metadata;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;

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
        if (!sentence.Contains(' '))
        {
            return string.Concat(sentence.Reverse());
        }

        string[] arrWords = sentence.Split().Where(str => str.Length >= 5).ToArray();

        StringBuilder result = new(sentence);

        for (int i = 0; i < arrWords.Length; i++)
        {
            result.Replace(arrWords.ElementAt(i), string.Concat(arrWords.ElementAt(i).Reverse()));
        }

        return result.ToString();
    }

    #endregion

    #region Create Phone Number

    public static string CreatePhoneNumber(int[] numbers)
    {
        StringBuilder strBuild = new();

        for (int i = 0; i <= numbers.Length - 1;)
        {
            switch (i)
            {
                case 0 when !strBuild.ToString().Contains('('):
                    strBuild.Append('(');
                    break;
                
                case 3 when !strBuild.ToString().Contains(')'):
                    strBuild.Append(')');
                    break;
                
                case 3 when !strBuild.ToString().Contains(' '):
                    strBuild.Append(' ');
                    break;
                
                case 6 when !strBuild.ToString().Contains('-'):
                    strBuild.Append('-');
                    break;
                
                default:
                    strBuild.Append(numbers[i]);
                    i++;
                    break;
            }
        }

        return strBuild.ToString();
    }

    #endregion
}