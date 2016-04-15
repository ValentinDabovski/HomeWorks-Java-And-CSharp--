import java.lang.invoke.SwitchPoint;
import java.util.*;

public class problem01 {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String[] input = sc.nextLine().split("\\W+");
        List<Integer> numbers = new ArrayList<>();

        for (int i = 0; i < input.length; i++) {
            numbers.add(Integer.parseInt(input[i]));
        }

        TreeMap<String, Integer> map = new TreeMap<>();

        for (int i = 0; i < numbers.size(); i++) {

            switch (numbers.get(i)) {

                case 0:
                    map.put("zero-", numbers.get(i));
                    break;

                case 1:
                    map.put("one-", numbers.get(i));
                    break;

                case 2:
                    map.put("two-", numbers.get(i));
                    break;

                case 3:
                    map.put("three-", numbers.get(i));
                    break;

                case 4:
                    map.put("four-", numbers.get(i));
                    break;

                case 5:
                    map.put("five-", numbers.get(i));
                    break;

                case 6:
                    map.put("six-", numbers.get(i));
                    break;

                case 7:
                    map.put("seven-", numbers.get(i));
                    break;

                case 8:
                    map.put("eight-", numbers.get(i));
                    break;

                case 9:
                    map.put("nine-", numbers.get(i));
                    break;

                default:
                    return;
            }
        }

       
        for (Integer i : map.values()) {

            System.out.printf();
        }
    }
}


