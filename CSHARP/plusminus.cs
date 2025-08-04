using System;
using System.Collections.Generic;

public class Solution
{
    static void plusMinus(List<int> arr)
    {
        
        int total=arr.Count;
        int positive=0,negative=0,zero=0;
        
        foreach(int num in arr)
        {
            if(num>0)
              positive++;
            else if(num<0)
              negative++;
            else
              zero++;
        }
            Console.WriteLine(((double)positive/total).ToString("F6"));
            Console.WriteLine(((double)negative/total).ToString("F6"));
            Console.WriteLine(((double)zero/total).ToString("F6"));
        
    }
     public static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            string[] inputs=Console.ReadLine().Split(' ');
            List<int> arr= new List<int>();
            
            foreach(string s in inputs)
            {
                arr.Add(Convert.ToInt32(s));
            }
             plusMinus(arr);
        }
}
