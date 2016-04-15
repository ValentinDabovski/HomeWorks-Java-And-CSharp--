import com.sun.org.apache.bcel.internal.generic.IF_ACMPEQ;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ExtractEmails {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();


        Pattern pattern = Pattern.compile("([a.-z])+(@[a.-z.]+)");
        Matcher matcher = pattern.matcher(input);


       if (matcher.find()) {
           System.out.println(matcher.group(0));

        }
    }
}
