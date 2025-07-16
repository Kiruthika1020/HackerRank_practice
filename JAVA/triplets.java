import java.util.*;

public class Solution {
    public static List<Integer> compareTriplets(List<Integer> a, List<Integer> b) {
        int alicePoints = 0;
        int bobPoints = 0;

        for (int i = 0; i < 3; i++) {
            if (a.get(i) > b.get(i)) {
                alicePoints++;
            } else if (a.get(i) < b.get(i)) {
                bobPoints++;
            }
        }

        List<Integer> result = new ArrayList<>();
        result.add(alicePoints);
        result.add(bobPoints);
        return result;
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        List<Integer> a = new ArrayList<>();
        for (int i = 0; i < 3; i++) {
            a.add(scanner.nextInt());
        }
        List<Integer> b = new ArrayList<>();
        for (int i = 0; i < 3; i++) {
            b.add(scanner.nextInt());
        }
        List<Integer> result = compareTriplets(a, b);
        for (int i = 0; i < result.size(); i++) {
            System.out.print(result.get(i));
            if (i < result.size() - 1) {
                System.out.print(" ");
            }
        }

        scanner.close();
    }
}
