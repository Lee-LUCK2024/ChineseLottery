/*
 * Description: SupperTool
 * Author: Chance.zheng
 * Creat Time: 2024/08/24 14:12:36 星期六
 * Copyright © CookCSharp 2024 All Rights Reserved.
 */


// Red: 1-35  Blue: 1-12

namespace AutoForecast;

public static class SupperTool
{
    #region 1-5 Red

    public static int[] GetFirstRed(int[] mantissaValues, int[] way012)
    {
        return Tool.GetRed(mantissaValues, way012).Where(n => n <= 31).ToArray();
    }

    public static int[] GetSecondRed(int[] mantissaValues, int[] way012)
    {
        return Tool.GetRed(mantissaValues, way012).Where(n => n <= 32).ToArray();
    }

    public static int[] GetThirdRed(int[] mantissaValues, int[] way012)
    {
        return Tool.GetRed(mantissaValues, way012).Where(n => n <= 33).ToArray();
    }

    public static int[] GetFourthRed(int[] mantissaValues, int[] way012)
    {
        return Tool.GetRed(mantissaValues, way012).Where(n => n <= 34).ToArray();
    }

    public static int[] GetFifthRed(int[] mantissaValues, int[] way012)
    {
        return Tool.GetRed(mantissaValues, way012).Where(n => n <= 35).ToArray();
    }

    public static int[] Amplitude(this int[] values, int value, int[] way012)
    {
        return values.Where(n => way012.Contains(Math.Abs(n - value) % 3)).ToArray();
    }

    #endregion

    #region Sum

    public static List<int[]> Sum12Filter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains((g[0] + g[1]) % 3)).ToList();
    }

    public static List<int[]> Sum13Filter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains((g[0] + g[2]) % 3)).ToList();
    }

    public static List<int[]> Sum14Filter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains((g[0] + g[3]) % 3)).ToList();
    }

    public static List<int[]> Sum15Filter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains((g[0] + g[4]) % 3)).ToList();
    }

    public static List<int[]> Sum23Filter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains((g[1] + g[2]) % 3)).ToList();
    }

    public static List<int[]> Sum24Filter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains((g[1] + g[3]) % 3)).ToList();
    }

    public static List<int[]> Sum25Filter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains((g[1] + g[4]) % 3)).ToList();
    }

    public static List<int[]> Sum34Filter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains((g[2] + g[3]) % 3)).ToList();
    }

    public static List<int[]> Sum35Filter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains((g[2] + g[4]) % 3)).ToList();
    }

    public static List<int[]> Sum45Filter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains((g[3] + g[4]) % 3)).ToList();
    }

    #endregion

    #region SumMantissa

    public static List<int[]> Sum12MantissaFilter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains((g[0] + g[1]) % 10)).ToList();
    }

    public static List<int[]> Sum13MantissaFilter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains((g[0] + g[2]) % 10)).ToList();
    }

    public static List<int[]> Sum14MantissaFilter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains((g[0] + g[3]) % 10)).ToList();
    }

    public static List<int[]> Sum15MantissaFilter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains((g[0] + g[4]) % 10)).ToList();
    }

    public static List<int[]> Sum23MantissaFilter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains((g[1] + g[2]) % 10)).ToList();
    }

    public static List<int[]> Sum24MantissaFilter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains((g[1] + g[3]) % 10)).ToList();
    }

    public static List<int[]> Sum25MantissaFilter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains((g[1] + g[4]) % 10)).ToList();
    }

    public static List<int[]> Sum34MantissaFilter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains((g[2] + g[3]) % 10)).ToList();
    }

    public static List<int[]> Sum35MantissaFilter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains((g[2] + g[4]) % 10)).ToList();
    }

    public static List<int[]> Sum45MantissaFilter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains((g[3] + g[4]) % 10)).ToList();
    }

    #endregion

    #region Span

    public static List<int[]> Span12Filter(this List<int[]> data, int[] way0123)
    {
        return data.Where(g => way0123.Contains(Math.Abs(g[1] - g[0]) % 3)).ToList();
    }

    public static List<int[]> Span13Filter(this List<int[]> data, int[] way0123)
    {
        return data.Where(g => way0123.Contains(Math.Abs(g[2] - g[0]) % 3)).ToList();
    }

    public static List<int[]> Span15Filter(this List<int[]> data, int[] way0123)
    {
        return data.Where(g => way0123.Contains(Math.Abs(g[4] - g[0]) % 3)).ToList();
    }

    public static List<int[]> Span23Filter(this List<int[]> data, int[] way0123)
    {
        return data.Where(g => way0123.Contains(Math.Abs(g[2] - g[1]) % 3)).ToList();
    }

    public static List<int[]> Span24Filter(this List<int[]> data, int[] way0123)
    {
        return data.Where(g => way0123.Contains(Math.Abs(g[3] - g[1]) % 3)).ToList();
    }

    public static List<int[]> Span25Filter(this List<int[]> data, int[] way0123)
    {
        return data.Where(g => way0123.Contains(Math.Abs(g[4] - g[1]) % 3)).ToList();
    }

    public static List<int[]> Span45Filter(this List<int[]> data, int[] way0123)
    {
        return data.Where(g => way0123.Contains(Math.Abs(g[4] - g[3]) % 3)).ToList();
    }

    #endregion

    #region SpanMantissa

    public static List<int[]> Span12MantissaFilter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains(Math.Abs(g[1] - g[0]) % 10)).ToList();
    }

    public static List<int[]> Span13MantissaFilter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains(Math.Abs(g[2] - g[0]) % 10)).ToList();
    }

    public static List<int[]> Span14MantissaFilter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains(Math.Abs(g[3] - g[0]) % 10)).ToList();
    }

    public static List<int[]> Span15MantissaFilter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains(Math.Abs(g[4] - g[0]) % 10)).ToList();
    }

    public static List<int[]> Span23MantissaFilter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains(Math.Abs(g[2] - g[1]) % 10)).ToList();
    }

    public static List<int[]> Span24MantissaFilter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains(Math.Abs(g[3] - g[1]) % 10)).ToList();
    }

    public static List<int[]> Span25MantissaFilter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains(Math.Abs(g[4] - g[1]) % 10)).ToList();
    }

    public static List<int[]> Span34MantissaFilter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains(Math.Abs(g[3] - g[2]) % 10)).ToList();
    }

    public static List<int[]> Span35MantissaFilter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains(Math.Abs(g[4] - g[2]) % 10)).ToList();
    }

    public static List<int[]> Span45MantissaFilter(this List<int[]> data, int[] mantissaValues)
    {
        return data.Where(g => mantissaValues.Contains(Math.Abs(g[4] - g[3]) % 10)).ToList();
    }

    #endregion

    #region Blue

    public static List<int[]> BlueFirstFilter(this List<int[]> data, int[] way012)
    {
        return data.Where(g => way012.Contains(g[0] % 3)).ToList();
    }

    public static List<int[]> BlueSecondFilter(this List<int[]> data, int[] way012)
    {
        return data.Where(g => way012.Contains(g[1] % 3)).ToList();
    }

    public static int[] BlueAmplitudeFilter(this int[] data, int value, int[] way012)
    {
        return data.Where(n => way012.Contains(Math.Abs(n - value) % 3)).ToArray();
    }

    public static List<int[]> BlueSumFilter(this List<int[]> data, int[] way012)
    {
        return data.Where(g => way012.Contains((g[0] + g[1]) % 3)).ToList();
    }

    public static List<int[]> BlueSumMantissaFilter(this List<int[]> data, int[] way012)
    {
        return data.Where(g => way012.Contains((g[0] + g[1]) % 10)).ToList();
    }

    public static List<int[]> BlueSpanFilter(this List<int[]> data, int[] way012)
    {
        return data.Where(g => way012.Contains(Math.Abs(g[1] - g[0]) % 3)).ToList();
    }

    public static List<int[]> BlueSpanMantissaFilter(this List<int[]> data, int[] way012)
    {
        return data.Where(g => way012.Contains(Math.Abs(g[1] - g[0]) % 10)).ToList();
    }

    #endregion

    public static List<int[]> FindAllSortedCombinations(int[] first, int[] second)
    {
        var result = new List<int[]>();
        GenerateCombinations(first, second, 0, [], result);
        return result;
    }

    private static void GenerateCombinations(int[] first, int[] second, int index, List<int> current, List<int[]> result)
    {
        if (index == 2)
        {
            // 当所有集合都已处理完，添加到结果
            result.Add([..current]);
            return;
        }

        var lists = new List<int[]> { first, second };
        var list = lists[index];

        // 递归处理每一个集合的每个元素
        foreach (var value in list)
        {
            if (current.Count == 0 || value > current[^1])
            {
                current.Add(value);
                GenerateCombinations(first, second, index + 1, current, result);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}