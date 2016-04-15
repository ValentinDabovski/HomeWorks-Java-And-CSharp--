import com.sun.org.apache.xpath.internal.SourceTree;
        import javafx.scene.paint.Material;

        import java.util.ArrayList;
        import java.util.Collections;
        import java.util.List;
        import java.util.Scanner;
        import java.util.regex.Matcher;
        import java.util.regex.Pattern;

public class CollectResources {

    static List<Integer> indexes = new ArrayList<>();
    static List<Integer> resourceCollected = new ArrayList<>();
    static int resourceCount = 0;

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        String[] resourceField = sc.nextLine().split(" ");
        int numberOfPaths = sc.nextInt();
        sc.nextLine();
        //  String[] stepPatterns = sc.nextLine().split(" ");


        for (int i = 0; i < numberOfPaths; i++) {
            indexes.clear();
            resourceCount = 0;
            String[] stepPath = sc.nextLine().split(" ");
            int startIndex = Integer.parseInt(stepPath[0]);
            int step = Integer.parseInt(stepPath[1]);

            for (int j = startIndex; j < resourceField.length; j = (j + step) % resourceField.length) {

                if (indexes.contains(j)) {
                    break;
                }

                collectResources(resourceField[j], j);
            }
            resourceCollected.add(resourceCount);
        }

        System.out.println(Collections.max(resourceCollected));
    }


    private static void collectResources(String resorce, int j) {

        if (resorce.startsWith("stone") ||
                resorce.startsWith("gold") ||
                resorce.startsWith("wood") ||
                resorce.startsWith("food")) {

            indexes.add(j);


            if (resorce.contains("_")) {

                resourceCount += Integer.parseInt(resorce.split("_")[1]);

            } else {
                resourceCount++;
            }
        }
    }
}
