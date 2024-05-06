import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
<<<<<<< HEAD
import java.util.Scanner;

public class RandomNumberGenerator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Введите число:");
        int n = scanner.nextInt();
=======

public class RandomNumberGenerator {
    public static void main(String[] args) {
        int n = 10;
>>>>>>> 3156145a60052f2c44e133a2a5396fbcdbbe42ae

        List<Integer> numbers = new ArrayList<>();
        for (int i = 1; i <= n; i++) {
            numbers.add(i);
        }

        // Перемешиваем числа в рандомном порядке
        Collections.shuffle(numbers);

        System.out.println("Случайные числа:");
        for (int num : numbers) {
            System.out.print(num + " ");
        }
    }
}
<<<<<<< HEAD
=======


>>>>>>> 3156145a60052f2c44e133a2a5396fbcdbbe42ae
