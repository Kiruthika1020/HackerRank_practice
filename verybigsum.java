import java.util.*;

public class Solution {

    public static long aVeryBigSum(long[] ar) 
    {
        long total = 0;
        for (long num : ar) 
        {
            total += num;
        }
        return total;
    }
    public static void main(String[] args) 
    {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        long[] ar = new long[n];
        for (int i = 0; i < n; i++) 
        {
            ar[i] = scanner.nextLong();
        }
        long result = aVeryBigSum(ar);
        System.out.println(result);
        scanner.close();
    }
}
