using System;
using System.Collections.Generic;

class Solution
{
    static List<int> compareTriplets(List<int> a,List<int> b)
    {
        int alicePoints=0;
        int bobPoints=0;
        for(int i=0;i<3;i++)
        {
          if(a[i]>b[i])
            alicePoints++;
           else if(a[i]<b[i])
            bobPoints++;
        }
         return new List<int>{alicePoints,bobPoints};
     }
        static void Main(string[]args)
        {
            List<int> a=Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            List<int> b=Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            List<int> result=compareTriplets(a,b);
            Console.WriteLine(string.Join(" ",result));
        }
}
