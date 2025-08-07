import java.util.*;

public class MiniMaxSum
{
    public static void MinMaxSum(int[] arr)
    {
        long totalSum=0;
        int min=arr[0];
        int max=arr[0];
        
        for(int num:arr)
        {
            totalSum+=num;
            if(num<min)
            {
                min=num;
            }
            if(num>max)
            {
                max=num;
            }
        }
        long minSum=totalSum-max;
        long maxSum=totalSum-min;
        
        System.out.println(minSum+" "+maxSum);
    }
    public static void main(String[] args)
    {
        Scanner sc=new Scanner(System.in);
        int[] arr=new int[5];
        for(int i=0;i<5;i++)
        {
            arr[i]=sc.nextInt();
            
        }
        MinMaxSum(arr);
        sc.close();
    }
}