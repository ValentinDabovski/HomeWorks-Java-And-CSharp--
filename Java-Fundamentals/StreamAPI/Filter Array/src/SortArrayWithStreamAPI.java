import java.util.Arrays;
import java.util.Scanner;

public class SortArrayWithStreamAPI {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        String[] input  = scanner.nextLine().split(" ");
        String command = scanner.next();
        Integer [] numbers= new Integer[input.length];

        for (int i = 0; i <input.length ; i++) {
            numbers[i] = Integer.parseInt(input[i]);
        }

        if (command.equals("Ascending")) {
            Arrays.stream(numbers).sorted().forEach(System.out::println);
        }

        else if (command.equals("Descending")) {
            Arrays.stream(numbers).sorted((f1,f2) -> f2.compareTo(f1)).forEach(System.out::println);
        }
    }
}


