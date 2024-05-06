import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

public class RandomNumberGenerator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Введите число:");
        int n = scanner.nextInt();

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
