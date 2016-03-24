import java.util.Scanner;
import java.util.regex.Matcher;

public class CharacterMultiplier {

    private static int sum;

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String first = scanner.next();
        String second = scanner.next();

        int minLength = Math.min(first.length(), second.length());

        for (int i = 0; i < minLength; i++) {

            characterMultiplier(first.charAt(i), second.charAt(i));
        }

        String longest = first.length() > second.length() ? first : second;
        for (int i = minLength; i <longest.length() ; i++) {
            sum += longest.charAt(i);
        }

        System.out.println(sum);
    }

    private static void characterMultiplier(char ch1, char ch2) {
        sum += (ch1 * ch2);
    }
}
