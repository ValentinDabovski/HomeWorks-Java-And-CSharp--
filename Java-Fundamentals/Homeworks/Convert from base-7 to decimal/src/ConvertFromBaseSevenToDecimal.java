
import com.sun.org.apache.xerces.internal.impl.xpath.regex.Match;

import java.util.Arrays;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

public class ConvertFromBaseSevenToDecimal {

    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        List<String> digits = Arrays.asList(scan.next().split(""));
        Collections.reverse(digits);

        int baseSevenNumber = 0;
        int number = 0;

        for (int i = 0; i < digits.size() ; i++) {
            number = Integer.parseInt(digits.get(i));
            baseSevenNumber +=  number * Math.pow(7, i);

        }

        System.out.println(baseSevenNumber);

    }
}
