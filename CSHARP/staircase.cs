using System;

public class solution
{
    public static void Main(string[] args)
    {
        int n=Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=n;i++)
        {
            string spaces=new string(' ',n-i);
            string hashes=new string('#',i);
            Console.WriteLine(spaces+hashes);
        }
    }
}
        
        