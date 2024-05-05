import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class RandomNumberGenerator {
    public static void main(String[] args) {
        int n = 10;

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


