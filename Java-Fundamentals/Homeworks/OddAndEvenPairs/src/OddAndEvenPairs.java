import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class OddAndEvenPairs {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String[] input = scanner.nextLine().split(" ");

        List<Integer> listInts = new ArrayList<Integer>();
        for (int i = 0; i <input.length ; i++) {

            listInts.add( Integer.parseInt(input[i]));
        }

        for (int i = 0; i < listInts.size() -1 ; i+=2) {

            if (listInts.size() % 2 != 0) {
                System.out.println("Invalid lenght");
                break;
            }

            else if (listInts.get(i) % 2 == 0 && listInts.get(i+1) % 2 == 0) {

                System.out.printf("%d, %d -> both are even \n",listInts.get(i), listInts.get(i+1));
            }

            else if (listInts.get(i) % 2 != 0 && listInts.get(i +1) % 2 != 0){

                System.out.printf("%d, %d -> both are odd \n",listInts.get(i), listInts.get(i+1));

            } else {
                System.out.printf("%d, %d -> different \n",listInts.get(i), listInts.get(i+1));
            }
        }
    }
}
