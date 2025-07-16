using System;
class program
{
    static void Main()
    {
        int n=Convert.ToInt32(Console.ReadLine());
        string[] input=Console.ReadLine().Split(' ');
        int[] arr=new int[n];
        for(int i=0; i<n ;i++)
        {
            arr[i]=Convert.ToInt32(input[i]);
        }
        int result=SimpleArraySum(arr);
        Console.WriteLine(result);
    }
    static int SimpleArraySum(int[] arr)
    {
        int total=0;
        for(int i=0; i<arr.Length; i++)
        {
            total+=arr[i];
        }
        return total;
    }
}
        


    
