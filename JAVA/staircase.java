import java.util.Scanner;

public class solution
{
    public static void main(String[] args)
    {
      Scanner sc=new Scanner(System.in);
      int n = sc.nextInt();
      sc.close();
      
      for (int i=1;i<=n;i++)
      {
        StringBuilder line = new StringBuilder();
        for(int j=0;j<n-i;j++)
        {
            line.append(" ");
        }
        for(int k=0;k<i;k++)
        {
            line.append("#");
        }
        System.out.println(line.toString());
      } 
    }
}