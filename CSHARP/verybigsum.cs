using System;
using System.Linq;

class solution
{
    static long aVeryBigSum(long[] ar)
    {
        long total=0;
        foreach(long num in ar)
        {
            total += num;
        }
        return total;
    }
        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine());
            long[] ar =Array.ConvertAll(Console.ReadLine().Split(' '),long.Parse);;
            long result = aVeryBigSum(ar);
            Console.WriteLine(result);
        }
}