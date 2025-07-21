using System;
using System.Collections.Generic;

class Solution
{
    public static int DiagonalDifference(List<List<int>> arr)
    {
        int n = arr.Count;
        int leftToRight = 0;
        int rightToLeft = 0;

        for (int i = 0; i < n; i++)
        {
            leftToRight += arr[i][i];
            rightToLeft += arr[i][n - 1 - i];
        }

        return Math.Abs(leftToRight - rightToLeft);
    }

    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        var matrix = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            var row = new List<int>();
            string[] inputs = Console.ReadLine().Split(' ');

            foreach (string input in inputs)
            {
                row.Add(Convert.ToInt32(input));
            }

            matrix.Add(row);
        }

        int result = DiagonalDifference(matrix);
        Console.WriteLine(result);
    }
}
