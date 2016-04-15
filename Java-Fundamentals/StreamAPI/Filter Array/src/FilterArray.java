import java.lang.reflect.Array;
import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;

public class FilterArray {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        String[] input = scanner.nextLine().split(" ");

        Arrays.stream(input).filter(p -> p.length() > 3).forEach(System.out::println);


    }
}


