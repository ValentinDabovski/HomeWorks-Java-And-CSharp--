import java.util.Scanner;
import java.util.regex.Matcher;

public class CalculateExpression {

    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        double a = scan.nextDouble();
        double b = scan.nextDouble();
        double c = scan.nextDouble();

        double formulaOne = (a * a + b * b) / (a * a - b * b);
        formulaOne = Math.pow(formulaOne,(a+b+c) / Math.sqrt(c));

     //  System.out.printf("%.2f",formulaOne);

        double formulaTwo = (a * a + b * b - c * c * c);
        formulaTwo = Math.pow(formulaTwo, (a-b));

      //  System.out.printf("%.2f",formulaTwo);


        double averrage = (a + b + c) / 3;
        double formulaAverage = (formulaOne + formulaTwo) / 2;
        double result = averrage - formulaAverage;

        System.out.printf("F1 result: %.2f; ",formulaOne);
        System.out.printf("F2 result: %.2f; ",formulaTwo);
        System.out.printf("Diff: %.2f;",Math.abs(result));
    }
}
