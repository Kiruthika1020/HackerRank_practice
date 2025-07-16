import java.io.*;
import java.util.Scanner;

public class main
{
    public static void main(String[] args)
    {
        Scanner s=new Scanner(System.in);
        int n=s.nextInt();
        int[] arr=new int[n];
        for(int i=0;i<n;i++)
        {
            arr[i]=s.nextInt();
        }
        int sum=simpleArraySum(arr);
        System.out.println(sum);
    }
    public static int simpleArraySum(int[]arr)
    {
        int total=0;
        for (int i=0;i<arr.length;i++)
        {
            total+=arr[i];
        }
        return total;
    }
}
 
    