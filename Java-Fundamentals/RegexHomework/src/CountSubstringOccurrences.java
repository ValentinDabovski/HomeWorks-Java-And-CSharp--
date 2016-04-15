import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class CountSubstringOccurrences {

    public static void main(String[] args) {


        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        String matchWord = sc.next();

        Pattern pattern = Pattern.compile("(?i)matchWord");
        Matcher matcher =  pattern.matcher(input);

        int counter = 0;

        for (int i = 0; i <input.length() ; i++) {
                if(matcher.find()) {

                    counter++;
                }
        }

        System.out.println(counter);
    }
}
