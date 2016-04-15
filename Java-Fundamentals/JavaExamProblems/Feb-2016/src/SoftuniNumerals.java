import javafx.scene.paint.Material;

import java.math.BigInteger;
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class SoftuniNumerals {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        Map<String,Integer> dictionary = new HashMap<>();
        dictionary.put("aa",0);
        dictionary.put("aba",1);
        dictionary.put("bcc",2);
        dictionary.put("cc",3);
        dictionary.put("cdc",4);

        String input = sc.nextLine();
        Pattern pattern = Pattern.compile("(aa|aba|bcc|cc|cdc)+?");
        Matcher matcher = pattern.matcher(input);
        StringBuilder decimalString = new StringBuilder();

        while (matcher.find()) {
            String currentKey = matcher.group();
            decimalString.append(dictionary.get(currentKey));

        }
        BigInteger big = new BigInteger(decimalString.toString(),5);

        System.out.println(big.toString(10));
    }
}

