using System;
using System.Linq;

class Solution
{
    static void MiniMaxSum(int[] arr)
    {
        long totalSum=arr.Sum(x =>(long)x);
        int min=arr.Min();
        int max=arr.Max();
        
        long minSum=totalSum-max;
        long maxSum=totalSum-min;
        
        Console.WriteLine(minSum + " " +maxSum);
        
    }
    static void Main(string[] args)
    {
        string[]input=Console.ReadLine().Split(' ');
        int[] arr=Array.ConvertAll(input,int.Parse);
        
        MiniMaxSum(arr);
    }
}
