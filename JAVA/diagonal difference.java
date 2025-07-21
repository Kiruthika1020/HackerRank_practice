import java.util.*;

public class DiagonalDifference {

    public static int diagonalDifference(List<List<Integer>> arr) {
        int n = arr.size();
        int leftToRight = 0;
        int rightToLeft = 0;

        for (int i = 0; i < n; i++) {
            leftToRight += arr.get(i).get(i);
            rightToLeft += arr.get(i).get(n - 1 - i);
        }

        return Math.abs(leftToRight - rightToLeft);
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = scanner.nextInt();
        List<List<Integer>> matrix = new ArrayList<>();

        for (int i = 0; i < n; i++) {
            List<Integer> row = new ArrayList<>();
            for (int j = 0; j < n; j++) {
                row.add(scanner.nextInt());
            }
            matrix.add(row);
        }

        int result = diagonalDifference(matrix);
        System.out.println(result);
    }
}
